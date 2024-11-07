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
    public class Arrow : GameObject
    {
        const float speed = 12f;
        Character owner;

        int destroyTimer;

        const int maxTimer = 180; // bullet destroy timer in ticks (60ticks/sec)

        public Arrow()
        {
            active = false;
        }

        public override void Load(ContentManager content)
        {
            image = TextureLoader.Load("bullet", content);
            base.Load(content);
        }

        // 6. Bullets and Decorations pt. 1 | Making a 2D Game Engine with FNA
        // Time : 8:00
    }
}
