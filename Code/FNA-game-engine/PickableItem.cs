using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNA_game_engine
{
    public class PickableItem : AnimatedObject
    {
        List<Equipement> loot = new List<Equipement>();
        public PickableItem()
        {

        }

        public PickableItem(Vector2 inputPosition)
        {
            position = inputPosition;
        }

        public override void Initialize()
        {
            base.Initialize();
            playerCollidable = false;
            this.loot.Add(new Equipement("lantern-spritesheet.png", "Lantern.anm", 0.450f, 0, 0, 0));
            this.loot.Last().Initialize();
        }

        public override void Load(ContentManager content)
        {
            //Load our image/sprite sheet:
            image = TextureLoader.Load("orbsheet", content);

            //Load any animation stuff if this object animates:
            LoadAnimation("PowerUp.anm", content);
            ChangeAnimation("IdleLeft"); //Set our default animation.

            //Load stuff from our parent class:
            base.Load(content);


            this.loot.ForEach(equipement => equipement.Load(content));
            //Customize the size of our bounding box for collisions:
            boundingBoxOffset.X = 30;
            boundingBoxOffset.Y = 30;
            boundingBoxWidth = animationSet.width - 60; //or use image.Width if it's not animated
            boundingBoxHeight = animationSet.height - 60; //or use image.Height if it's not animated
        }

        public override void Update(List<GameObject> objects, Map map)
        {
            if (!active)
            {
                return;
            }
            CheckPlayerCollision(objects, map);
            base.Update(objects, map);
        }

        private void CheckPlayerCollision(List<GameObject> objects, Map map)
        {
            for (int i = 0; i < objects.Count; i++)
            {
                if (objects[i] is Player)
                {
                    if (objects[i].CheckCollision(boundingBox) && AnimationIsNot("PickUp"))
                    {
                        Player.score++;
                        this.loot.ForEach(equipement => equipement.sourceObject = objects[0]);
                        this.loot.ForEach(equipement => equipement.Initialize());
                        objects[0].equipements.AddRange(loot);
                        // ADDRANGE TO PLAYER EQUIPEMENT

                        // HERE

                        // HERE
                        ChangeAnimation("PickUp");
                    }
                }
            }
        }

        protected override void UpdateAnimations()
        {
            if (currentAnimation == null)
            {
                return; // Animation isnt loaded, so return
            }
            base.UpdateAnimations();

            if (AnimationComplete() && GetAnimationName("PickUp") == currentAnimation.name)
            {
                active = false;
            }
        }
    }
}
