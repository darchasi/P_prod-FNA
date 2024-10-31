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
        /// <summary>
        /// Update position
        /// </summary>
        /// <param name="inputPosition"></param>
        public Player(Vector2 inputPosition)
        {
            position = inputPosition;
        }

        public override void Initilize()
        {
            base.Initilize();
        }
        /// <summary>
        /// Load player sprite
        /// </summary>
        /// <param name="content"></param>
        public override void Load(ContentManager content)
        {
            image = TextureLoader.Load("sprite", content);
            base.Load(content);
        }
        /// <summary>
        /// Update object position
        /// </summary>
        /// <param name="objects"></param>
        public override void Update(List<GameObject> objects)
        {
            CheckInput();
            base.Update(objects);
        }
        /// <summary>
        /// Player movement
        /// </summary>
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
