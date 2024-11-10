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
        public static float camrot = 0;
        public const int PIXELWIDTH = 640;
        public const int PIXELHEIGHT = 360;
        public const int SCREENWIDTH = 1280;
        public const int SCREENHEIGHT = 720;
        
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public List<GameObject> objects = new List<GameObject>();
        public Map map = new Map();

        GameHUD gameHUD = new GameHUD();
        Editor editor;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // Set window size

            Resolution.Init(ref graphics);
            Resolution.SetVirtualResolution(PIXELWIDTH, PIXELHEIGHT);

            Resolution.SetResolution(SCREENWIDTH, SCREENHEIGHT, false);
        }

        protected override void Initialize()
        {
#if DEBUG
            editor = new Editor(this);
            editor.Show();
#endif
            base.Initialize();
            Camera.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
#if DEBUG
            editor.LoadTextures(Content);
#endif
            map.Load(Content);
            gameHUD.Load(Content);
            LoadLevel();
        }

        protected override void Update(GameTime gameTime)
        {
            Input.Update();
            UpdateObjects();
            map.Update(objects);
            UpdateCamera();

#if DEBUG
            editor.Update(objects, map);
#endif
            Camera.rotation += camrot;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            // set color to LightPink
            GraphicsDevice.Clear(Color.LightPink);

            Resolution.BeginDraw();

            // Draw sprite(s)
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend, SamplerState.LinearClamp, DepthStencilState.Default, RasterizerState.CullNone, null, Camera.GetTransformMatrix());
#if DEBUG
            editor.Draw(spriteBatch);
#endif
            DrawObjects();
            map.DrawWalls(spriteBatch);
            spriteBatch.End();

            gameHUD.Draw(spriteBatch);
            base.Draw(gameTime);
        }
        public void LoadLevel()
        {
            objects.Add(new Player(new Vector2(640, 360)));

            objects.Add(new Enemy(new Vector2(300, 522)));

            // Add walls
            map.walls.Add(new Wall(new Rectangle(76, 460, 206, 60), true));

            map.walls.Add(new Wall(new Rectangle(456, 280, 146, 56), true));

            map.walls.Add(new Wall(new Rectangle(780, 160, 236, 64), true));

            map.walls.Add(new Wall(new Rectangle(730, 480, 76, 30), true));

            map.walls.Add(new Wall(new Rectangle(980, 490, 76, 30), true));

            map.walls.Add(new Wall(new Rectangle(1100, 320, 90, 26), true));

            map.walls.Add(new Wall(new Rectangle(0, 650, 4096, 128), true));

            // Add decor
            map.decor.Add(new Decor(Vector2.Zero, "background", 1f));
            map.LoadMap(Content);

            LoadObjects();
        }
        public void LoadObjects()
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Initialize();
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

            for (int i = 0; i < map.decor.Count; i++)
            {
                map.decor[i].Draw(spriteBatch);
            }
        }

        private void UpdateCamera()
        {
            if (objects.Count == 0)
            {
                return;
            }

            Camera.Update(objects[0].position);
            //Camera.Update(GetCamHeightDiff(objects[0].position + objects[0].center));
        }

        private Vector2 GetCamHeightDiff(Vector2 pos)
        {
            pos.Y = pos.Y - 130;
            return pos;
        }
    }
}
