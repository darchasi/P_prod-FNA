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

        public override void Initilize()
        {
            jumpVelocity = 20f;
            score = 0;
            base.Initilize();
        }

        public override void Load(ContentManager content)
        {
            image = TextureLoader.Load("player1", content);
            base.Load(content);
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
    }
}
