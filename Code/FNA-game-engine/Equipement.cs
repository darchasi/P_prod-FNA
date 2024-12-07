using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;


namespace FNA_game_engine
{
    public class Equipement : AnimatedObject
    {
        public string newCostumeName = "new costume";
        public int offsetX = 0;
        public int offsetY = 0;
        public int turnOfsetX = 0;
        public bool mirror = false;
        public GameObject sourceObject;
        public string anmPath;

        public Equipement()
        {

        }

        /*
        public Equipement(string costumeName, string inputAnmPath, float layer, int XOS, int YOS, int TOF)
        {
            active = false;
            anmPath = inputAnmPath;
            projectileCollidable = false;
            playerCollidable = false;
            name = costumeName;
            layerDepth = layer;
            offsetX = XOS;
            offsetY = YOS;
            turnOfsetX = TOF;
        }*/

        public Equipement(GameObject source, string costumeName, string inputAnmPath, float layer, int XOS, int YOS, int TOF, bool isActive)
        {
            active = isActive;
            anmPath = inputAnmPath;
            projectileCollidable = false;
            playerCollidable = false;
            name = costumeName;
            layerDepth = layer;
            sourceObject = source;
            position = sourceObject.position;
            offsetX = XOS;
            offsetY = YOS;
            turnOfsetX = TOF;
            sourceObject.equipements.Add(this);
        }

        public override void Initialize()
        {
            if (sourceObject != null)
            {
                active = true;
            }
            if (startPosition == new Vector2(-1, -1))
            {
                startPosition = position;
            }
            
        }
        public override void Update(List<GameObject> objects, Map map)
        {
            if (sourceObject != null)
            {
                active = true;
            }
            else
            {
                active = false;
            }

            if (sourceObject.direction.X == 1 && active)
            {
                this.direction.X = 1;
                spriteEffects = SpriteEffects.None;
                position = SetOffset(sourceObject.position, false);
            }
            else if (sourceObject.direction.X == -1)
            {
                this.direction.X = -1;
                spriteEffects = SpriteEffects.FlipHorizontally;
                position = SetOffset(sourceObject.position, true);
            }
            else
            {
                position = SetOffset(sourceObject.position, false);
            }

            base.Update(objects, map);

            // Vérifier si l'animation de tir est terminée
            if (currentAnimation != null && currentAnimation.name.Contains("Fire") && currentAnimationFrame == currentAnimation.animationOrder.Count - 1)
            {
                    if (sourceObject is FireCharacter fireCharacter && !fireCharacter.hasFiredProjectile)
                    {
                        fireCharacter.FireProjectile(); // Lancer la flèche
                        fireCharacter.hasFiredProjectile = true; // Marquer le tir comme effectué
                    }

                    // Revenir à l'animation idle une fois le tir effectué
                    if (currentAnimation.name.Contains("Left"))
                        ChangeAnimation("Idle Left");
                    else
                        ChangeAnimation("Idle Right");
            }

            if (currentAnimation != null)
            {
                UpdateAnimations();
            }
        }


        public Vector2 SetOffset(Vector2 sourcePos, bool turn)
        {
            if (turn)
            {
                sourcePos.X += turnOfsetX;
            }
            sourcePos.X += offsetX;
            sourcePos.Y += offsetY;
            return sourcePos;
        }

        public override void Load(ContentManager content)
        {
            if (anmPath != null)
            {
                image = TextureLoader.Load(name, content);
                // Load animation
                LoadAnimation(anmPath, content);
                ChangeAnimation("IdleLeft");
            }
            else
            {
                image = TextureLoader.Load(name, content);
            }

            base.Load(content);

        }

        /*
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (image != null)
            {
                spriteBatch.Draw(image, position, null, drawColor, MathHelper.ToRadians(rotation), Vector2.Zero, scale, spriteEffects, layerDepth);
            }
        }*/
    }
}
