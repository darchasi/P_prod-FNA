﻿using System;
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
    public class GameObject
    {
        //Varibles positions
        protected Texture2D image;
        public Vector2 position;
        public Color drawColor = Color.White;
        public float scale = 1f, rotation = 0f;
        public float layerDepth = .5f;
        public bool active = true;
        protected Vector2 center;

        public GameObject() 
        { 
        
        }

        public virtual void Initilize()
        {

        }
        /// <summary>
        /// Load sprite on the center
        /// </summary>
        /// <param name="content"></param>
        public virtual void Load(ContentManager content)
        {
            CalculateCenter();
        }

        public virtual void Update(List<GameObject> objects)
        {

        }
        /// <summary>
        /// Draw all sprites of the game
        /// </summary>
        /// <param name="spriteBatch"></param>
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if(image != null && active == true)
            {
            spriteBatch.Draw(image, position,null, drawColor, rotation, Vector2.Zero, scale, SpriteEffects.None, layerDepth);
            }

        }
        /// <summary>
        /// Calcul center for sprites
        /// </summary>
        private void CalculateCenter()
        {
            if (image == null)
            {
                return;
            }

            center.X = image.Width/2;
            center.Y = image.Height/2;
        }
    }
}
