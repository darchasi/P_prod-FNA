using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SDL2;
using Color = Microsoft.Xna.Framework.Color;

namespace FNA_game_engine
{
    //TO ADD NEW GAME OBJECTS TO THE EDITOR FOLLOW THESE INSTRUCTIONS:
    //1. Add the name of the object to the enum ObjectType (make sure it's spelled exactly the same). Make sure you add it BEFORE NumOfObjects.
    //2. Make sure objectsNamespace is correctly set. This should be the namespace that all your classes are under. Go to Player.cs and copy the namespace that's there, it's likely the one you need.

    public partial class GameInterface : Form
    {
        public Game1 game;
    }
}
