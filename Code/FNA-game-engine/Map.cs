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
        public List<Wall> walls = new List<Wall>();
        Texture2D wallImage;

        public int mapWidth = 15;
        public int mapHeight = 9;
        public int tileSize = 128;

        public void Load(ContentManager content)
        {
            wallImage = TextureLoader.Load("pixel", content);
        }

        /// <summary>
        /// Checks for collision between two rectangles
        /// </summary>
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

        /// <summary>
        /// Draw walls 
        /// </summary>
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
}
