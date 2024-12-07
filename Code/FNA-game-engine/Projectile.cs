using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace FNA_game_engine
{
    public class Projectile : GravityPbject
    {
        const float PROJDECEL = 1;
        const int baseXvelocity = 2;
        Character owner;
        int destroyTimer;
        const int maxTimer = 180; // bullet destroy timer in ticks (60ticks/sec)

        public Projectile()
        {
            active = false;
            playerCollidable = false;
        }

        public override void Load(ContentManager content)
        {
            image = TextureLoader.Load("bullet1", content);
            base.Load(content);
        }

        public override void Update(List<GameObject> objects, Map map)
        {
            if (!active)
            {
                return;
            }

            UpdateMovement(objects, map);
            // Update deathtimer
            destroyTimer--;
            if (destroyTimer <= 0 && active)
            {
                Destroy();
            }
            base.Update(objects, map);


        }

        public void Fire(Character inputOwner, Vector2 inputPositon, Vector2 inputDirection)
        {
            owner = inputOwner;
            position = inputPositon;
            direction = inputDirection;
            decel = PROJDECEL;
            if (direction.X > 0)
            {
                velocity.X = baseXvelocity;
            }
            else
            {
                velocity.X = -baseXvelocity;
            }
            active = true;
            destroyTimer = maxTimer;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (!active) return;

            SpriteEffects spriteEffect = direction.X < 0 ? SpriteEffects.FlipHorizontally : SpriteEffects.None;

            spriteBatch.Draw(image,position,null,Color.White,0f, Vector2.Zero,1f,spriteEffect,0f);
        }

        public override void UpdateMovement(List<GameObject> objects, Map map)
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
                    Destroy();
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
                    Destroy();
                }
            }

            // Décélération pour les mouvements horizontaux
            //velocity.X = TendToZero(velocity.X, decel);

            // Décélération verticale uniquement si la gravité est désactivée
            if (!applyGravity)
            {
                velocity.Y = TendToZero(velocity.Y, decel);
            }
        }

        public override bool CheckCollisions(Map map, List<GameObject> objects, bool xAxis)
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
                    futureBoundingBox.Y -= 20;
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
                if (objects[i] != this && objects[i].active && objects[i] != owner && objects[i].projectileCollidable && objects[i].CheckCollision(futureBoundingBox))
                {
                    return true;
                }
            }

            // If no collision detected
            return false;
        }

        public void Destroy()
        {
            active = false;
        }
    }
}
