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
        public const int SCREENWIDTH = 1280;
        public const int SCREENHEIGHT = 720;
        
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public List<GameObject> objects = new List<GameObject>();
        public Map map = new Map();
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // Set window size
            graphics.PreferredBackBufferWidth = SCREENWIDTH;
            graphics.PreferredBackBufferHeight = SCREENHEIGHT;

            // Set fullscreen on
            graphics.IsFullScreen = false;

            // Apply graphic changes
            graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            base.Initialize();

        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            map.Load(Content);
            LoadLevel();
        }

        protected override void Update(GameTime gameTime)
        {
            Input.Update();
            UpdateObjects();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            // set color to LightPink
            GraphicsDevice.Clear(Color.LightPink);

            // Draw sprite(s)
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            DrawObjects();
            map.DrawWalls(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
        public void LoadLevel()
        {
            objects.Add(new Player(new Vector2(640, 360)));

            objects.Add(new Enemy(new Vector2(300, 522)));

            //Add walls
            map.walls.Add(new Wall(new Rectangle(256, 256, 256, 256), true));

            map.walls.Add(new Wall(new Rectangle(0, 650, 1280, 128), true));

            LoadObjects();
        }
        public void LoadObjects()
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Initilize();
                objects[i].Load(Content);
            }
        }

        public void UpdateObjects()
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Update(objects, map);
            }
        }

        public void DrawObjects()
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Draw(spriteBatch);
            }
        }
    }
}
