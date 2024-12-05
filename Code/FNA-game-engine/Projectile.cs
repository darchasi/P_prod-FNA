using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

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
            image = TextureLoader.Load("bullet1", content);
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
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (!active) return;

            SpriteEffects spriteEffect = direction.X < 0 ? SpriteEffects.FlipHorizontally : SpriteEffects.None;

            spriteBatch.Draw(image,position,null,Color.White,0f, Vector2.Zero,1f,spriteEffect,0f);
        }

        private void CheckCollision(List<GameObject> objects, Map map)
        {

            var collidedObject =  objects.FirstOrDefault(obj => obj.active && obj != owner && obj.projectileCollidable && obj.CheckCollision(boundingBox));

            if (collidedObject != null)
            {
                Destroy();
                collidedObject.ProjectileResponse();
                return;
            }

            //Verify collision
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
