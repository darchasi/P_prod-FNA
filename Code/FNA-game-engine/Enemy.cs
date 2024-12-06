using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FNA_game_engine
{
    public class Enemy : Character
    {
        int respawnTimer;
        const int minRespawnTimer = 50;
        const int maxRespawnTimer = 200;

        int jumpTimer;
        const int minJumpTimer = 100;
        const int maxJumpTimer = 200;

        int moveTimer;
        const int minMoveTimer = 20;
        const int maxMoveTimer = 50;

        Random random = new Random();

        SoundEffect explosion;

        public Enemy()
        {

        }

        public Enemy(string inputName, Vector2 inputPosition)
        {
            name = inputName;
            position = inputPosition;
        }

        public override void Initialize()
        {
            active = true;
            playerCollidable = false;
            position.X = random.Next(1342, 1922);
            jumpTimer = maxJumpTimer;
            moveTimer = maxMoveTimer;

            base.Initialize();
        }

        public override void Load(ContentManager content)
        {
            image = TextureLoader.Load("enemy", content);
            explosion = content.Load<SoundEffect>("Audio\\explosion");
            base.Load(content);
            ConfigureBoundingBox();
        }

        private void ConfigureBoundingBox()
        {
            
            boundingBoxOffset = new Vector2(image.Width/4, 15);
            boundingBoxWidth = (int)(image.Width / 2);
            boundingBoxHeight = (int)(image.Height / 1.2);
        }

        public override void Update(List<GameObject> objects, Map map)
        {
            if (respawnTimer > 0)
            {
                respawnTimer--;
                if (respawnTimer <= 0)
                {
                    Initialize();
                }
            }

            if (jumpTimer > 0)
            {
                jumpTimer--;
                if (jumpTimer <= 0)
                {
                    Jump(map);
                    jumpTimer = random.Next(minJumpTimer,maxJumpTimer);
                }
            }

            if (moveTimer > 0)
            {
                moveTimer--;
                if (moveTimer <= 0)
                {
                    int zeroOrOne = new Random().Next(0,2);
                    if (zeroOrOne == 1)
                    {
                        velocity.X += random.Next(3, 10);
                    }
                    else
                    {
                        velocity.X -= random.Next(3, 10);
                    }
                    moveTimer = random.Next(minMoveTimer, maxMoveTimer);
                }
            }
            base.Update(objects, map);
        }

        public override void ProjectileResponse()
        {
            active = false;
            respawnTimer = random.Next(minRespawnTimer, maxRespawnTimer);
            Player.score++;
            //Game1.camrot += 0.005f;
            explosion.Play(0.1f, 0f, 0f);

            base.ProjectileResponse();
        }
    }
}
