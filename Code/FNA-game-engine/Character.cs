using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System;

namespace FNA_game_engine
{
    public class Character : AnimatedObject
    {

        public const float DECEL = 0.5f;
        public const float ACCEL = 1f;
        public const float MAXSPEED = 8f;
        public const float GRAVITY = 1f;
        public const float JUMPVELOCITY = 22f;
        public const float MAXFALLVELOCITY = 24f + 8f * GRAVITY;

        public Vector2 velocity;
        // customize feel of the movement

        public float decel; // lower number is, slower character slows down.
        public float accel; // lower number is, slower character takes off.
        public float maxSpeed;

        public float gravity;
        public float jumpVelocity; // how much jump.
        public float maxFallVelocity;

        protected bool jumping;
        // static = always available even if no Character loaded
        public static bool applyGravity = true;

        public override void Initialize()
        {
            velocity = Vector2.Zero;
            jumping = false;
            decel = DECEL;
            accel = ACCEL;
            maxSpeed = MAXSPEED;
            gravity = GRAVITY;
            jumpVelocity = JUMPVELOCITY;
            maxFallVelocity = MAXFALLVELOCITY;
            base.Initialize();
        }

        public override void Update(List<GameObject> objects, Map map)
        {
            UpdateMovement(objects, map);
            base.Update(objects, map);
        }
        private void UpdateMovement(List<GameObject> objects, Map map)
        {
            // Appliquer la gravité avant de vérifier les collisions
            if (applyGravity)
            {
                ApplyGravity(map);
            }

            // Gérer les mouvements horizontaux
            if (velocity.X != 0)
            {
                // Vérifier la collision horizontale avant de déplacer
                if (!CheckCollisions(map, objects, true)) // true = vérifier les collisions horizontales
                {
                    position.X += velocity.X; // Appliquer le mouvement si pas de collision
                }
                else
                {
                    velocity.X = 0; // Stopper le mouvement si collision
                }
            }

            // Gérer les mouvements verticaux
            if (velocity.Y != 0)
            {
                // Vérifier la collision verticale avant de déplacer
                if (!CheckCollisions(map, objects, false)) // false = vérifier les collisions verticales
                {
                    position.Y += velocity.Y; // Appliquer le mouvement si pas de collision
                }
                else
                {
                    velocity.Y = 0; // Stopper le mouvement si collision
                    jumping = false; // Réinitialiser le saut si une collision est détectée
                }
            }

            // Décélération pour les mouvements horizontaux
            velocity.X = TendToZero(velocity.X, decel);

            // Décélération verticale uniquement si la gravité est désactivée
            if (!applyGravity)
            {
                velocity.Y = TendToZero(velocity.Y, decel);
            }
        }


        private void ApplyGravity(Map map)
        {
            // Vérifier si le personnage est au sol
            bool isOnGround = OnGround(map) != Rectangle.Empty;

            if (!isOnGround || jumping)
            {
                velocity.Y += gravity;
            }

            // Limiter la vitesse de chute
            if (velocity.Y > maxFallVelocity)
            {
                velocity.Y = maxFallVelocity;
            }
        }

        protected Rectangle OnGround(Map map)
        {
            // Ajuster légèrement vers le bas pour détecter le sol
            Rectangle futureBoundingBox = new Rectangle(
                (int)(position.X + boundingBoxOffset.X),
                (int)(position.Y + boundingBoxOffset.Y + gravity), // +1 pour simuler un léger déplacement vers le bas
                boundingBoxWidth,
                boundingBoxHeight
            );

            return map.CheckCollision(futureBoundingBox);
        }

        protected void MoveRight()
        {
            velocity.X += accel + decel;

            if (velocity.X > maxSpeed)
            {
                velocity.X = maxSpeed;
            }
            direction.X = 1;
        }

        protected void MoveLeft()
        {
            velocity.X -= accel + decel;

            if (velocity.X < -maxSpeed)
            {
                velocity.X = -maxSpeed;
            }
            direction.X = -1;
        }
        protected void MoveDown()
        {
            velocity.Y += accel + decel;

            if (velocity.Y > maxSpeed)
            {
                velocity.Y = maxSpeed;
            }
            direction.Y = 1;
        }

        protected void MoveUp()
        {
            velocity.Y -= accel + decel;

            if (velocity.Y < -maxSpeed)
            {
                velocity.Y = -maxSpeed;
            }
            direction.Y = -1;
        }

        protected bool Jump(Map map)
        {
            if (jumping)
            {
                return false;
            }
            // Able to jump
            if (velocity.Y == 0 && (OnGround(map) != Rectangle.Empty || gravity == 0))
            {
                velocity.Y -= jumpVelocity;
                jumping = true;
                return true;
            }
            return false;
        }

        // calculate if next frame will cause a collision, if yes, stop the character
        // bool xAxis true if checking for X axis and false if checking for Y axis
        protected virtual bool CheckCollisions(Map map, List<GameObject> objects, bool xAxis)
        {
            Rectangle futureBoundingBox = boundingBox;

            int maxX = (int)(Math.Abs(velocity.X) + accel);
            int maxY = (int)(velocity.Y + gravity);
            /*
            if (applyGravity)
            {
                maxY = (int)jumpVelocity;
            }*/

            // Stop movement at X contact
            if (xAxis && velocity.X != 0)
            {
                if (velocity.X > 0)
                {
                    futureBoundingBox.X += maxX;
                }
                else
                {
                    futureBoundingBox.X -= maxX;
                }
            }
            // Stop movement at Y contact
            else if (!applyGravity && !xAxis && velocity.Y != 0)
            {
                if (velocity.Y > 0)
                {
                    futureBoundingBox.Y += maxY;
                }
                else
                {
                    futureBoundingBox.Y -= maxY;
                }
            }
            // Stop movement at Y contact
            else if (applyGravity && !xAxis && velocity.Y != gravity)
            {
                if (velocity.Y > 0)
                {
                    futureBoundingBox.Y += maxY;
                }
                else
                {
                    futureBoundingBox.Y -= (int)jumpVelocity;
                }
            }

            // Check for wall collision
            Rectangle wallCollision = map.CheckCollision(futureBoundingBox);

            if (wallCollision != Rectangle.Empty)
            {
                // Lands character on floor if it gets too close
                if (applyGravity && velocity.Y >= gravity && (futureBoundingBox.Bottom > wallCollision.Top) && (boundingBox.Right > wallCollision.Left) && (boundingBox.Left < wallCollision.Right))
                {
                    LandResponse(wallCollision);
                    return true;
                }
                else
                {
                    return true;
                }
            }

            // Check for object collisions

            for (int i = 0; i < objects.Count; i++)
            {
                if (objects[i] != this && objects[i].active && objects[i].playerCollidable && objects[i].CheckCollision(futureBoundingBox))
                {
                    return true;
                }
            }

            // If no collision detected
            return false;
        }

        public void LandResponse(Rectangle wallCollision)
        {
            position.Y = wallCollision.Top - (boundingBoxHeight + boundingBoxOffset.Y);

            velocity.Y = 0;

            jumping = false;
        }

        // Move value towards 0
        protected float TendToZero(float val, float amount)
        {
            if (val > 0f && (val -= amount) < 0f) return 0f;
            if (val < 0f && (val += amount) > 0f) return 0f;
            return val;
        }
    }
}
