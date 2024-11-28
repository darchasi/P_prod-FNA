using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using System.Collections.Generic;
using System.Linq;

namespace FNA_game_engine
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        public static float camrot = 0;
        public const int PIXELWIDTH = 640 *2;
        public const int PIXELHEIGHT = 360*2;
        public const int SCREENWIDTH = 1280;
        public const int SCREENHEIGHT = 720;
        
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public List<GameObject> objects = new List<GameObject>();
        public Map map = new Map();

        GameHUD gameHUD = new GameHUD();
        Editor editor;
        SoundEffect song;
        SoundEffectInstance songInstance;

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
            Global.Initialize(this);
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
#if DEBUG
            editor.LoadTextures(Content, map);
#endif
            map.Load(Content);
            gameHUD.Load(Content);
            // Load song
            // No need to add "Content\\" because the content manager already starts in Content folder by default
            song = Content.Load<SoundEffect>("Audio\\song");

            if (songInstance == null)
            {
                songInstance = song.CreateInstance();
                songInstance.Volume = 0.2f;
            }
            LoadLevel("NewLevel.lvl");
        }

        protected override void Update(GameTime gameTime)
        {
            Input.Update();
            UpdateObjects();
            map.Update(objects);
            UpdateCamera();
            UpdateMusic();

#if DEBUG
            editor.Update(objects, map);
#endif
            Camera.zoom = 1.4f;
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
        private void UpdateMusic()
        {
            if (songInstance.State != SoundState.Playing)
            {
                songInstance.IsLooped = true;
                songInstance.Play();
            }
        }
        public void LoadLevel(string fileName)
        {
            Global.levelName = fileName;

            // Load level data

            LevelData levelData = XmlHelper.Load("Content\\Levels\\" +  fileName);


            // Add walls
            map.walls = levelData.walls;

            // Add decor
            map.decor = levelData.decor;

            objects.Add(new Player(new Vector2(1652, 2940)));

            objects.Add(new Enemy(new Vector2(1392, 3002)));

            //objects.Add(new Equipement(objects[0], "hat.png", null, 0.490f, 16, 2, 0));

            //objects[0].equipements.Add(new Equipement(objects[0], "lantern-spritesheet.png", "Lantern.anm", 0.450f, 0, 0, 0));
            //objects.Add(objects[0].equipements.Last());
            //objects.Add(new Equipement(objects[0], "lantern", 0.510f, -78, -83, -34));

            /*
            map.walls.Add(new Wall(new Rectangle(16, 860, 2060, 60), true));

            map.walls.Add(new Wall(new Rectangle(456, 280, 146, 56), true));

            map.decor.Add(new Decor(Vector2.Zero, "background", 1f));
            */

            map.LoadMap(Content);

            LoadObjects();
        }
        public void LoadObjects()
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects.ToList().ForEach(obj => {
                    obj.Initialize();
                    obj.Load(Content);
                });
            }

        }

        public void UpdateObjects()
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Update(objects, map);
                if (objects[i].equipements.Count() > 0)
                {
                    objects[i].equipements.ForEach(equipement => equipement.Update(objects, map));
                }
            }
            /*
            objects.ForEach(obj =>
            {
                obj.Update(objects, map);
                {
                    if (obj.equipements.Count() > 0)
                    {
                        obj.equipements.ForEach(equipement => equipement.Update(objects, map));
                    }
                }
            });*/
        }

        public void DrawObjects()
        {
            objects.ToList().ForEach(obj => obj.Draw(spriteBatch));
            map.decor.ToList().ForEach(obj => obj.Draw(spriteBatch));
        }

        private void UpdateCamera()
        {
            if (objects.Count == 0)
            {
                return;
            }

            //Camera.Update(objects[0].position);
            Camera.Update(GetCamHeightDiff(objects[0].position));
        }

        private Vector2 GetCamHeightDiff(Vector2 pos)
        {
            pos.Y = pos.Y + 54;
            pos.X = pos.X + 54;
            return pos;
        }
    }
}
