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
        int currentAnimState;
        enum animStates
        {
            IdleLeft,
            IdleRight,
            RunLeft,
            RunRight
        }

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
            image = TextureLoader.Load("player-spritesheet", content);

            // Load animation
            LoadAnimation("Player1.anm", content);
            ChangeAnimation("IdleLeft");
            base.Load(content);

            boundingBoxOffset.X = animationSet.width/4;
            boundingBoxOffset.Y = 20;
            boundingBoxWidth = animationSet.width /2;
            boundingBoxHeight = animationSet.height -22;
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

            if (this.equipements.Count > 0 && this.equipements.Where(equip => equip.animationSet.animationList.Where(anim => anim.name == "Light").Count() > 0).Count() >= 0)
            {
                if (velocity != Vector2.Zero || jumping)
                {
                    if (direction.X < 0 && AnimationIsNot("RunLightLeft"))
                    {
                        currentAnimState = (int)animStates.RunLeft;
                        ChangeAnimation("RunLightLeft");
                    }
                    else if (direction.X > 0 && AnimationIsNot("RunLightRight"))
                    {
                        currentAnimState = (int)animStates.RunRight;
                        ChangeAnimation("RunLightRight");
                    }
                }
                else if (velocity == Vector2.Zero || !jumping)
                {
                    if (direction.X < 0 && AnimationIsNot("IdleLightLeft"))
                    {
                        currentAnimState = (int)animStates.IdleLeft;
                        ChangeAnimation("IdleLightLeft");
                    }
                    else if (direction.X > 0 && AnimationIsNot("IdleLightRight"))
                    {
                        currentAnimState = (int)animStates.IdleRight;
                        ChangeAnimation("IdleLightRight");
                    }
                }
            }
            else
            {
                if (velocity != Vector2.Zero || jumping)
                {
                    if (direction.X < 0 && AnimationIsNot("RunLeft"))
                    {
                        currentAnimState = (int)animStates.RunLeft;
                        ChangeAnimation("RunLeft");
                    }
                    else if (direction.X > 0 && AnimationIsNot("RunRight"))
                    {
                        currentAnimState = (int)animStates.RunRight;
                        ChangeAnimation("RunRight");
                    }
                }
                else if (velocity == Vector2.Zero || !jumping)
                {
                    if (direction.X < 0 && AnimationIsNot("IdleLeft"))
                    {
                        currentAnimState = (int)animStates.IdleLeft;
                        ChangeAnimation("IdleLeft");
                    }
                    else if (direction.X > 0 && AnimationIsNot("IdleRight"))
                    {
                        currentAnimState = (int)animStates.IdleRight;
                        ChangeAnimation("IdleRight");
                    }
                }
            }
        }
    }
}
