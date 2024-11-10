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
    public class GameObject
    {
        protected Texture2D image;
        public Vector2 position;
        public Color drawColor = Color.White;
        public float scale = 1f, rotation = 0f;
        public float layerDepth = .5f;
        public bool active = true;
        public Vector2 center;
        // will need to change for object walkthough-able
        public bool collidable = true;
        protected int boundingBoxWidth, boundingBoxHeight;
        protected Vector2 boundingBoxOffset;
        Texture2D boundingBoxImage;
        protected Vector2 direction = new Vector2(1,0);
        // for dev
        const bool drawBoundingBoxes = true;

        public Vector2 startPosition = new Vector2(-1, -1);

        // property use so that boundingBox calculates its position every time it is called, this way it is always up to date even if it changes position each frame.
        public Rectangle boundingBox
        {
            get
            {
                // returns new rectangle with position calculated with current position + offset, converted to int
                return new Rectangle((int)(position.X + boundingBoxOffset.X), (int)(position.Y + boundingBoxOffset.Y), boundingBoxWidth, boundingBoxHeight);
            }
        }


        public GameObject() 
        { 
        
        }

        public virtual void Initialize()
        {
            if (startPosition == new Vector2(-1,-1))
            {
                startPosition = position;
            }
        }

        public virtual void SetToDefaultPosition()
        {
            position = startPosition;
        }

        public virtual void Load(ContentManager content)
        {
            boundingBoxImage = TextureLoader.Load("pixel", content);

            CalculateCenter();

            // sets boundingbox dimentions to image dimentions by default
            if (image != null)
            {
                boundingBoxWidth = image.Width;
                boundingBoxHeight = image.Height;
            }
        }

        public virtual void Update(List<GameObject> objects, Map map)
        {

        }

        public virtual bool CheckCollision(Rectangle input)
        {
            return boundingBox.Intersects(input);
        }
        
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (boundingBoxImage != null && drawBoundingBoxes && active)
            {
                // new Color(120,120,120,120) for debug
                spriteBatch.Draw(boundingBoxImage, new Vector2(boundingBox.X, boundingBox.Y), boundingBox, Color.Transparent, 0f, Vector2.Zero, 1f, SpriteEffects.None, .1f);
            }
            if (image != null && active)
            {
            spriteBatch.Draw(image, position,null, drawColor, MathHelper.ToRadians(rotation), Vector2.Zero, scale, SpriteEffects.None, layerDepth);
            }
        }

        public virtual void ProjectileResponse()
        {

        }

        /*
        public virtual void GiveSpriteEffect(Texture2D image, int effect)
        {
            if (image != null && active)
            {
                Graphics.DrawI(image, position, null, drawColor, MathHelper.ToRadians(rotation), Vector2.Zero, scale, SpriteEffects[effect], layerDepth);
            }
        }*/

        public void CalculateCenter()
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
