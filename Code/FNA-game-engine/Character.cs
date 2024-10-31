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
    internal class Character : GameObject
    {
        public Vector2 velocity;

        // customize feel of the movement

        protected float decel = 1.2f; // lower number is, slower character slows down.
        protected float accel = 1.2f; // lower number is, slower character takes off.
        protected float maxSpeed = 5f;

        const float gravity = 1f;
        const float jumpVelocity = 16f; // how much jump.
        const float maxFallVelocity = 32;

        protected bool jumping;
        // static = always available even if no Character loaded
        public static bool applyGravity = false;

        public override void Initilize()
        {
            velocity = Vector2.Zero;
            jumping = false;
            base.Initilize();
        }

        public override void Update(List<GameObject> objects, Map map)
        {
            base.Update(objects, map);
        }
        protected virtual bool CheckCollisions(Map map, List<GameObject> objects, bool xAxis)
        {
            // calculate if next frame will cause a collision, if yes, stop the character
            Rectangle futureBoundingBox = boundingBox;

            int maxX = (int)maxSpeed;
            int maxY = (int)maxSpeed;

            if (applyGravity)
            {
                // TO CONTINUE
                // 10:06
                // 5. Collision Detection and Physics pt. 2 | Making a 2D Game Engine with FNA
            }
        }
    }
}
