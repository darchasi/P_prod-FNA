using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FNA_game_engine
{
    public class Map
    {
        public List<Decor> decor = new List<Decor>();
        public List<Wall> walls = new List<Wall>();
        Texture2D wallImage;

        public int mapWidth = 240; // 8k background image / 
        public int mapHeight = 135;
        public int tileSize = 32;

        public void Load(ContentManager content)
        {
            wallImage = TextureLoader.Load("pixel", content);
        }

        public void LoadMap(ContentManager content)
        {
            decor.ToList().ForEach(d => d.Load(content, d.imagePath));
        }

        // No need to pass Map since this is Map class, using this instead
        public void Update(List<GameObject> gameObjects)
        {
            decor.ToList().ForEach(d => d.Update(gameObjects, this));

        }

        // Checks for collision between two rectangles
        public Rectangle CheckCollision(Rectangle input)
        {
            // if it collides return the rectangle it collided with
            var collision = walls.FirstOrDefault(wall =>wall != null && wall.wall.Intersects(input) && wall.active);
            //otherwise returns an empty rectangle
            return collision?.wall ?? Rectangle.Empty;
        }

        public void DrawWalls(SpriteBatch spriteBatch)
        {
            walls.Where(wall => wall != null && wall.active).ToList().ForEach(wall =>
            {
                spriteBatch.Draw(wallImage,
                    new Vector2(wall.wall.X, wall.wall.Y),
                    wall.wall,
                    wall.defaultColor,
                    wall.defaultRotation,
                    Vector2.Zero,
                    wall.defaultScale,
                    SpriteEffects.None, wall.defaultLayerDepth
                );
             });
                
        }

        // Get tile index from coordonates
        public Point GetTileIndex(Vector2 inputPosition)
        {
            if (inputPosition == new Vector2 (-1, -1))
            {
                return new Point(-1, -1);
            }

            return new Point((int)inputPosition.X / tileSize, (int)inputPosition.Y / tileSize);
        }
    }

    public class Wall
    {
        public Color defaultColor = Color.DarkSlateGray;
        public Single defaultScale = 1f;
        public Single defaultRotation = 0f;
        public Single defaultLayerDepth = .7f;
        public Rectangle wall;
        public bool active;

        public Wall()
        {

        }

        public Wall(Rectangle inputRectangle, bool isActive)
        {
            wall = inputRectangle;
            active = isActive;
        }
    }

    public class Decor : GameObject
    {
        public string imagePath;
        public Rectangle sourceRectangle;

        public string Name { get { return imagePath; } }

        public Decor()
        {
            playerCollidable = false;
        }

        public Decor(Vector2 inputPosition, string inputImagePath, float inputDepth)
        {
            position = inputPosition;
            imagePath = inputImagePath;
            layerDepth = inputDepth;
            active = true;
            playerCollidable = false;
        }

        public virtual void Load(ContentManager content, string asset)
        {
            image = TextureLoader.Load(asset, content);
            image.Name = asset;
            boundingBoxWidth = image.Width;
            boundingBoxHeight = image.Height;

            if (sourceRectangle == Rectangle.Empty)
            {
                sourceRectangle = new Rectangle(0, 0, image.Width, image.Height);
            }
        }

        public void SetImage(Texture2D input, string newPath)
        {
            image = input;
            imagePath = newPath;
            // set both var to image.Width
            boundingBoxWidth = sourceRectangle.Width = image.Width;
            boundingBoxHeight= sourceRectangle.Height = image.Height;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (IsReadyToDraw())
            {
                DrawImage(spriteBatch);
            }
        }

        private bool IsReadyToDraw()
        {
            return image != null && active;
        }

        private void DrawImage(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, position, sourceRectangle, drawColor, rotation, Vector2.Zero, scale, SpriteEffects.None, layerDepth);
        }
    }
}
