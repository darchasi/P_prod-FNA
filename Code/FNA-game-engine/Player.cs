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
    public class Player : GameObject
    {
        public Player() 
        {

        } 

        public Player(Vector2 inputPosition)
        {
            position = inputPosition;
        }

        public override void Initilize()
        {
            base.Initilize();
        }

        public override void Load(ContentManager content)
        {
            image = TextureLoader.Load("sprite", content);
            base.Load(content);
        }

        public override void Update(List<GameObject> objects, Map map)
        {
            CheckInput();
            base.Update(objects, map);
        }

        private void CheckInput()
        {
            if (Input.IsKeyDown(Keys.D) == true || Input.IsKeyDown(Keys.Right))
            {
                position.X += 5;
            }
            else if (Input.IsKeyDown(Keys.A) == true || Input.IsKeyDown(Keys.Left))
            {
                position.X -= 5;
            }
            else if (Input.IsKeyDown(Keys.S) == true || Input.IsKeyDown(Keys.Down))
            {
                position.Y += 5;
            }
            else if (Input.IsKeyDown(Keys.W) == true || Input.IsKeyDown(Keys.Up))
            {
                position.Y -= 5;
            }
        }
    }
}
