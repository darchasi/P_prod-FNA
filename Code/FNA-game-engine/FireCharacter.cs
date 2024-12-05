using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Linq;

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
                projectiles.AddRange(Enumerable.Range(0, numOfProjectiles).Select(_ => new Projectile()));
            }
            base.Initialize();
        }

        public void Fire()
        {
            projectiles.ToList().FirstOrDefault(p => !p.active)?.Fire(this, position, direction);
        }

        public override void Load(ContentManager content)
        {
            projectiles.ToList().ForEach(p => p.Load(content));
            base.Load(content);
        }

        public override void Update(List<GameObject> objects, Map map)
        {
            projectiles.ToList().ForEach(projectile => projectile.Update(objects, map));
            base.Update(objects, map);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            projectiles.ToList().ForEach(p => p.Draw(spriteBatch));
            base.Draw(spriteBatch);
        }
    }
}
