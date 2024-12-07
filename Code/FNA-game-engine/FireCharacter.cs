using Microsoft.Xna.Framework;
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
        Vector2 startOffSet;
        public bool hasFiredProjectile = false;
        const int YOFFSET = 20;
        const int XOFFSET = 20;
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
            if (currentAnimation.name.Contains("Left"))
            {
                equipements.Where(equip => equip.name == "crossbow-spritesheet.png").ToList().Last().ChangeAnimation("Fire Left");
            }
            else
            {
                equipements.Where(equip => equip.name == "crossbow-spritesheet.png").ToList().Last().ChangeAnimation("Fire Right");
            }

            hasFiredProjectile = false;

        }

        public void FireProjectile()
        {
            if (hasFiredProjectile) return; // Empêche de tirer plusieurs projectiles par animation

            Vector2 projectileStartPosition = new Vector2(position.X + XOFFSET, position.Y + YOFFSET);

            var projectile = projectiles.FirstOrDefault(p => !p.active);
            if (projectile != null)
            {
                startOffSet = new Vector2(position.X + XOFFSET, position.Y + YOFFSET);
                //projectile.Fire(this, projectileStartPosition, direction); // Lancer le projectile
                projectile.Fire(this, startOffSet, direction);
                hasFiredProjectile = true; // Marquer que le projectile a été tiré
            }
        }


        /*
        public void FireProjectile()
        {
            Vector2 projectileStartPosition = new Vector2(position.X + XOFFSET, position.Y + YOFFSET);

            var projectile = projectiles.FirstOrDefault(p => !p.active);
            if (projectile != null)
            {
                projectile.Fire(this, projectileStartPosition, direction);
                hasFiredProjectile = true;
            }
        }
        */
        public override void Load(ContentManager content)
        {
            projectiles.ToList().ForEach(p => p.Load(content));
            base.Load(content);
        }

        /*
        public override void Update(List<GameObject> objects, Map map)
        {
            if (currentAnimation != null && currentAnimation.name.Contains("Fire"))
            {
                if (currentAnimationFrame == 2 && !hasFiredProjectile)
                {
                    FireProjectile();
                }
            }

            projectiles.ToList().ForEach(projectile => projectile.Update(objects, map));
            base.Update(objects, map);
        }*/

        public override void Update(List<GameObject> objects, Map map)
        {
            base.Update(objects, map);

            // Réinitialise `hasFiredProjectile` si aucune animation de tir n'est en cours
            if (equipements.All(equip => equip.currentAnimation == null || !equip.currentAnimation.name.Contains("Fire")))
            {
                hasFiredProjectile = false;
            }

            projectiles.ForEach(projectile => projectile.Update(objects, map));
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            projectiles.ToList().ForEach(p => p.Draw(spriteBatch));
            base.Draw(spriteBatch);
        }
    }
}
