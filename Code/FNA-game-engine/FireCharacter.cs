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
    public class FireCharacter : Character
    {
        List<Projectile> projectiles = new List<Projectile>();

        const int numOfProjectiles = 20;

        public FireCharacter() { }

        public override void Initialize()
        {
            if (projectiles.Count == 0)
            {
                /*for (int i = 0; i < numOfProjectiles; i++)
                {
                    projectiles.Add(new Projectile());
                }*/
                projectiles.AddRange(Enumerable.Range(0, numOfProjectiles).Select(_ => new Projectile()));
            }
            base.Initialize();
        }

        public void Fire()
        {
            /*for (int i =0; i < numOfProjectiles;i++)
            {
                if (!projectiles[i].active)
                {
                    projectiles[i].Fire(this, position, direction);
                    break;
                }
            }*/

            projectiles.ToList().FirstOrDefault(p => !p.active)?.Fire(this, position, direction);
        }

        public override void Load(ContentManager content)
        {
            /*for (int i = 0; i < numOfProjectiles; i++)
            {
                projectiles[i].Load(content);
            }*/

            projectiles.ToList().ForEach(p => p.Load(content));
            base.Load(content);
        }

        public override void Update(List<GameObject> objects, Map map)
        {
            /*for (int i = 0; i < numOfProjectiles; i++)
            {
                projectiles[i].Update(objects, map);
            }*/

            projectiles.ToList().ForEach(projectile => Update(objects, map));
            base.Update(objects, map);
        }

        public override void Draw (SpriteBatch spriteBatch)
        {
            /*
            for (int i = 0; i < numOfProjectiles; i++)
            {
                projectiles[i].Draw(spriteBatch);
            }*/

            projectiles.ToList().ForEach(p => p.Draw(spriteBatch));
            base.Draw(spriteBatch);
        }
    }
}
