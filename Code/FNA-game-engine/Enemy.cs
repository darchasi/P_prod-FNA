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
using System.Diagnostics.Contracts;

namespace FNA_game_engine
{
    public class Enemy : Character
    {
        int respawnTimer;
        const int maxRespawnTimer = 20;

        Random random = new Random();

        SoundEffect explosion;

        public Enemy()
        {

        }

        public Enemy(Vector2 inputPosition)
        {
            position = inputPosition;
        }

        public override void Initilize()
        {
            active = true;
            collidable = false;
            position.X = random.Next(0, Game1.SCREENWIDTH);
            base.Initilize();
        }

        public override void Load(ContentManager content)
        {
            image = TextureLoader.Load("enemy", content);
            explosion = content.Load<SoundEffect>("Audio\\explosion");
            base.Load(content);
        }

        public override void Update(List<GameObject> objects, Map map)
        {
            if (respawnTimer > 0)
            {
                respawnTimer--;
                if (respawnTimer <= 0)
                {
                    Initilize();
                }
            }
            base.Update(objects, map);
        }

        public override void ProjectileResponse()
        {
            active = false;
            respawnTimer = maxRespawnTimer;
            Player.score++;
            //Game1.camrot += 0.005f;
            explosion.Play(0.05f, 0f, 0f);

            base.ProjectileResponse();
        }
    }
}
