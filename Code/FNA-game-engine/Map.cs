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
    public class Map
    {
        public List<Decor> decors = new List<Decor>();
        public List<Wall> walls = new List<Wall>();
        Texture2D wallImage;

        public int mapWidth = 15;
        public int mapHeight = 9;
        public int tileSize = 128;

        public void Load(ContentManager content)
        {
            wallImage = TextureLoader.Load("pixel", content);
        }
        public void LoadMap(ContentManager content)
        {
            for (int i = 0; i < decors.Count; i++)
            {
                decors[i].Load(content, decors[i].imagePath);
            }
        }

        // No need to pass Map since this is Map class, using this instead
        public void Update(List<GameObject> gameObjects)
        {
            for (int i = 0;i < decors.Count;i++)
            {
                decors[i].Update(gameObjects, this);
            }

        }

        // Checks for collision between two rectangles
        public Rectangle CheckCollision(Rectangle input)
        {
            // for each wall, check if it collides with input rectangle
            for (int i = 0; i < walls.Count; i++)
            {
                // if it collides return the rectangle it collided with
                if (walls[i] != null && walls[i].wall.Intersects(input) == true && walls[i].active == true)
                {
                    return walls[i].wall;
                }
            }
            //otherwise returns an empty rectangle
            return Rectangle.Empty;
        }


        public void DrawWalls(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < walls.Count; i++)
            {
                if (walls[i] != null && walls[i].active== true)
                {
                    spriteBatch.Draw(wallImage, new Vector2(walls[i].wall.X, walls[i].wall.Y), walls[i].wall, walls[i].defaultColor, walls[i].defaultRotation, Vector2.Zero, walls[i].defaultScale, SpriteEffects.None, walls[i].defaultLayerDepth);
                }
            }
        }
    }

    public class Wall
    {
        public Color defaultColor = Color.Black;
        public Single defaultScale = 1f;
        public Single defaultRotation = 0f;
        public Single defaultLayerDepth = .7f;
        public Rectangle wall;
        public bool active;

        public Wall() { }

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
            collidable = false;
        }

        public Decor(Vector2 inputPosition, string inputImagePath, float inputDepth)
        {
            position = inputPosition;
            imagePath = inputImagePath;
            layerDepth = inputDepth;
            active = true;
            collidable = false;
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
            if (image != null && active)
            {
                spriteBatch.Draw(image, position, sourceRectangle, drawColor, rotation, Vector2.Zero, scale, SpriteEffects.None, layerDepth);
            }
        }
    }
}
