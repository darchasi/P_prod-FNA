using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using System.Security;
namespace FNA_game_engine
{
    public class Player : FireCharacter
    {
        public static int score;
        public Player() 
        {

        }

        public Player(Vector2 inputPosition)
        {
            position = inputPosition;
        }

        public override void Initialize()
        {
            jumpVelocity = 20f;
            score = 0;
            base.Initialize();
        }

        public override void Load(ContentManager content)
        {
            image = TextureLoader.Load("spritesheet", content);

            // Load animation
            LoadAnimation("ShyBoy.anm", content);
            ChangeAnimation(Animations.IdleLeft);
            base.Load(content);

            boundingBoxOffSet.X = animationSet.width /4;
            boundingBoxOffSet.Y = 10;
            boundingBoxWidth = animationSet.width /2;
            boundingBoxHeight = animationSet.height - 20;
        }

        public override void Update(List<GameObject> objects, Map map)
        {
            CheckInput(objects, map);
            base.Update(objects, map);
        }

        private void CheckInput(List<GameObject> objects, Map map)
        {
            if (applyGravity)
            {
                if (Input.IsKeyDown(Keys.D) || Input.IsKeyDown(Keys.Right))
                {
                    MoveRight();
                }
                else if (Input.IsKeyDown(Keys.A) || Input.IsKeyDown(Keys.Left))
                {
                    MoveLeft();
                }
                if (Input.KeyPressed(Keys.Space))
                {
                    Jump(map);
                }
            }
            else
            {
                if (Input.IsKeyDown(Keys.D) || Input.IsKeyDown(Keys.Right))
                {
                    MoveRight();
                }
                else if (Input.IsKeyDown(Keys.A) || Input.IsKeyDown(Keys.Left))
                {
                    MoveLeft();
                }
                if (Input.IsKeyDown(Keys.S) || Input.IsKeyDown(Keys.Down))
                {
                    MoveDown();
                }
                else if (Input.IsKeyDown(Keys.W) || Input.IsKeyDown(Keys.Up))
                {
                    MoveUp();
                }
            }

            if (Input.KeyPressed(Keys.W))
            {
                Fire();
            }
        }
        protected override void UpdateAnimations()
        {
            if (currentAnimation == null)
            {
                return;
            }

            base.UpdateAnimations();

            if (velocity !=  Vector2.Zero || jumping)
            {
                if (direction.X < 0 && AnimationIsNot(Animations.RunLeft))
                {
                    ChangeAnimation(Animations.RunLeft);
                }
                else if (direction.X > 0 && AnimationIsNot(Animations.RunRight))
                {
                    ChangeAnimation(Animations.RunRight);
                }
            }
            else if (velocity == Vector2.Zero || !jumping)
            {
                if (direction.X < 0 && AnimationIsNot(Animations.IdleLeft))
                {
                    ChangeAnimation(Animations.IdleLeft);
                }
                else if (direction.X > 0 && AnimationIsNot(Animations.IdleRight))
                {
                    ChangeAnimation(Animations.IdleRight);
                }
            }

        }
    }
}
