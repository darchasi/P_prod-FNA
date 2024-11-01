﻿using Microsoft.Xna.Framework;
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

        public List<GameObject> objects = new List<GameObject>();
        /// <summary>
        /// Screen creation
        /// </summary>
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
            base.Initialize();

        }
        /// <summary>
        /// Load Content
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            LoadLevel();
        }
        /// <summary>
        /// Game time
        /// </summary>
        /// <param name="gameTime"></param>
        protected override void Update(GameTime gameTime)
        {
            Input.Update();
            UpdateObjects();
            base.Update(gameTime);
        }
        /// <summary>
        /// Set Color background
        /// </summary>
        /// <param name="gameTime"></param>
        protected override void Draw(GameTime gameTime)
        {
            // set color to LightPink
            GraphicsDevice.Clear(Color.LightPink);

            // Draw sprite(s)
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            DrawObjects();
            spriteBatch.End();

            base.Draw(gameTime);
        }
        /// <summary>
        /// Load level
        /// </summary>
        public void LoadLevel()
        {
            objects.Add(new Player(new Vector2(640, 360)));
            LoadObjects();
        }
        /// <summary>
        /// Load of players
        /// </summary>
        public void LoadObjects()
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Initilize();
                objects[i].Load(Content);
            }
        }
        /// <summary>
        /// Update objects
        /// </summary>
        public void UpdateObjects()
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Update(objects);
            }
        }
        /// <summary>
        /// Draw objects
        /// </summary>
        public void DrawObjects()
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Draw(spriteBatch);
            }
        }
    }
}
