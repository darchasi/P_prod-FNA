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
    public class Projectile : GameObject
    {
        const float speed = 12f;
        Character owner;

        int destroyTimer;

        const int maxTimer = 180; // bullet destroy timer in ticks (60ticks/sec)

        public Projectile()
        {
            active = false;
        }

        public override void Load(ContentManager content)
        {
            image = TextureLoader.Load("bullet", content);
            base.Load(content);
        }

        public override void Update(List<GameObject> objects, Map map)
        {
            if (!active)
            {
                return;
            }

            // Update movement
            position += direction * speed;

            CheckCollision(objects, map);

            // Update deathtimer
            destroyTimer--;
            if (destroyTimer <= 0 && active)
            {
                Destroy();
            }
            base.Update(objects, map);

        }

        public void Fire(Character inputOwner, Vector2 inputPositon, Vector2 inputDirection)
        {
            owner = inputOwner;
            position = inputPositon;
            direction = inputDirection;
            active = true;
            destroyTimer = maxTimer;
        }
        private void CheckCollision(List<GameObject> objects, Map map)
        {
            for (int i = 0 ; i < objects.Count; i++)
            {
                if (objects[i].active && objects[i] != owner && objects[i].projectileCollidable && objects[i].CheckCollision(boundingBox))
                {
                    Destroy();
                    objects[i].ProjectileResponse();
                    return;
                }
            }

            if (map.CheckCollision(boundingBox) != Rectangle.Empty)
            {
                Destroy();
            }
        }
        public void Destroy()
        {
            active = false;
        }
    }
}
