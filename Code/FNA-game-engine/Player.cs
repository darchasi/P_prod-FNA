using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System.Linq;

namespace FNA_game_engine
{
    public class Player : FireCharacter
    {
        int timeAttack = 0;
        public static int score;
        int currentAnimState;
        enum animStates
        {
            IdleLeft,
            IdleRight,
            RunLeft,
            RunRight,
            IdleLightLeft,
            IdleLightRight,
            RunLightLeft,
            RunLightRight,
        }

        public Player() 
        {

        }

        public Player(string inputName, Vector2 inputPosition)
        {
            name = inputName;
            position = inputPosition;
        }

        public override void Initialize()
        {
            //jumpVelocity = 20f;
            score = 0;
            base.Initialize();
        }

        public override void Load(ContentManager content)
        {
            base.Load(content);
            PlayerLoadAnimation(content);
            ConfigureBoundingBox();
        }
        private void PlayerLoadAnimation(ContentManager content)
        {
            image = TextureLoader.Load("player-spritesheet", content);

            // Load animation
            LoadAnimation("Player1.anm", content);
            ChangeAnimation("IdleLeft");
        }
        private void ConfigureBoundingBox()
        {
            boundingBoxOffset = new Vector2(animationSet.width / 4, 20);
            boundingBoxWidth = animationSet.width / 2;
            boundingBoxHeight = animationSet.height - 22;
        }
        public override void Update(List<GameObject> objects, Map map)
        {
            timeAttack--;
            CheckInput(objects, map);
            base.Update(objects, map);
        }

        private void CheckInput(List<GameObject> objects, Map map)
        {
            HandleMovement(map);
            HandleFire();
        }

        private void HandleMovement(Map map)
        {
            HandleHorizontalMovement();

            if (applyGravity)
            {
                HandleJump(map);
            }
            else
            {
                HandleVerticalMovement();
            }
        }

        private void HandleHorizontalMovement()
        {
            if (Input.IsKeyDown(Keys.D) || Input.IsKeyDown(Keys.Right))
            {
                MoveRight();
            }
            else if (Input.IsKeyDown(Keys.A) || Input.IsKeyDown(Keys.Left))
            {
                MoveLeft();
            }
        }

        private void HandleJump(Map map)
        {
            if (Input.KeyPressed(Keys.Space))
            {
                Jump(map);
            }
        }

        private void HandleVerticalMovement()
        {
            if (Input.IsKeyDown(Keys.S) || Input.IsKeyDown(Keys.Down))
            {
                MoveDown();
            }
            else if (Input.IsKeyDown(Keys.W) || Input.IsKeyDown(Keys.Up))
            {
                MoveUp();
            }
        }

        private void HandleFire()
        {
            bool hasCrossbow = equipements.Any(equip => equip.name == "crossbow-spritesheet.png");

            if (hasCrossbow && Input.IsKeyDown(Keys.E))
            {
                var crossbow = equipements.FirstOrDefault(equip => equip.name == "crossbow-spritesheet.png");

                if (crossbow != null && (crossbow.currentAnimation == null || !crossbow.currentAnimation.name.Contains("Fire")))
                {
                    if (direction.X < 0) 
                        crossbow.ChangeAnimation("Fire Left");
                    else
                        crossbow.ChangeAnimation("Fire Right");
                }
            }
        }




        protected override void UpdateAnimations()
        {
            if (currentAnimation == null)
                return;

            base.UpdateAnimations();

            if (velocity != Vector2.Zero || jumping)
            {
                HandleMovementAnimation();
            }
            else
            {
                HandleIdleAnimation();
            }
        }

        private void HandleMovementAnimation()
        {
            if (this.equipements.Count > 0 && this.equipements.Where(equip => equip.animationSet.animationList.Where(anim => anim.name == "Light").Count() > 0).Count() > 0)
            {
                if (direction.X < 0 && AnimationIsNot("RunLightLeft"))
                {
                    SetAnimationState(animStates.RunLightLeft, "RunLightLeft");
                }
                else if (direction.X > 0 && AnimationIsNot("RunLightRight"))
                {
                    SetAnimationState(animStates.RunLightRight, "RunLightRight");
                }
            }
            else
            {
                if (direction.X < 0 && AnimationIsNot("RunLeft"))
                {
                    SetAnimationState(animStates.RunLeft, "RunLeft");
                }
                else if (direction.X > 0 && AnimationIsNot("RunRight"))
                {
                    SetAnimationState(animStates.RunRight, "RunRight");
                }
            }
        }

        private void HandleIdleAnimation()
        {
            if (this.equipements.Count > 0 && this.equipements.Where(equip => equip.animationSet.animationList.Where(anim => anim.name == "Light").Count() > 0).Count() > 0)
            {
                if (direction.X < 0 && AnimationIsNot("IdleLightLeft"))
                {
                    SetAnimationState(animStates.IdleLightLeft, "IdleLightLeft");
                }
                else if (direction.X > 0 && AnimationIsNot("IdleLightRight"))
                {
                    SetAnimationState(animStates.IdleLightRight, "IdleLightRight");
                }
            }
            else
            {
                if (direction.X < 0 && AnimationIsNot("IdleLeft"))
                {
                    SetAnimationState(animStates.IdleLeft, "IdleLeft");
                }
                else if (direction.X > 0 && AnimationIsNot("IdleRight"))
                {
                    SetAnimationState(animStates.IdleRight, "IdleRight");
                }
            }
        }

        private void SetAnimationState(animStates state, string animation)
        {
            currentAnimState = (int)state;
            ChangeAnimation(animation);
        }

    }
}
