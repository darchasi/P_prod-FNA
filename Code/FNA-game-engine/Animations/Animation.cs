using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace FNA_game_engine
{
    public class Animation // Individual animation, many of them makes up an AnimationSet
    {
        public string name;
        public List<int> animationOrder = new List<int>();
        public int speed;

        public Animation()
        {

        }

        public Animation(string inputName, int inputSpeed, List<int> inputAnimationOrder)
        {
            name = inputName;
            speed = inputSpeed;
            animationOrder = inputAnimationOrder;
        }
    }

    public class AnimationSet
    {
        public int width;
        public int height;
        public int gridX; // how many frames in X direction
        public int gridY; // how many frames in Y direction
        public List<Animation> animationList = new List<Animation>();

        public AnimationSet()
        {

        }

        public AnimationSet(int inputWidth, int inputHeight, int inputgridX, int inputgridY)
        {
            width = inputWidth;
            height = inputHeight;
            gridX = inputgridX;
            gridY = inputgridY;
        }
    }

    public class AnimationData
    {
        public AnimationSet animation { get; set; }
        public string texturePath { get; set; }
    }
}
