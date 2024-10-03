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
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D image;
        Vector2 position;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // Set window size
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;

            // Set fullscreen on
            graphics.IsFullScreen = false;

            // Apply graphic changes
            graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            position = new Vector2 (640, 360);
            base.Initialize();

        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load in sprite image
            image = TextureLoader.Load("sprite2", Content);
        }

        protected override void Update(GameTime gameTime)
        {
            Input.Update();

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
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            // set color to LightPink
            GraphicsDevice.Clear(Color.LightPink);

            // Draw sprite(s)
            spriteBatch.Begin();
            spriteBatch.Draw(image, position, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
