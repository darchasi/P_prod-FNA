using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
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
            if (Input.KeyPressed(Keys.E))
            {
                Fire();
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
            if (direction.X < 0 && AnimationIsNot("RunLeft"))
            {
                SetAnimationState(animStates.RunLeft, "RunLeft");
            }
            else if (direction.X > 0 && AnimationIsNot("RunRight"))
            {
                SetAnimationState(animStates.RunRight, "RunRight");
            }
        }

        private void HandleIdleAnimation()
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

        private void SetAnimationState(animStates state, string animation)
        {
            currentAnimState = (int)state;
            ChangeAnimation(animation);
        }

    }
}
