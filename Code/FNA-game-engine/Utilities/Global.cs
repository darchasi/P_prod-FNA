﻿using System;

namespace FNA_game_engine
{
    static class Global
    {
        public static Game1 game;
        public static Random random = new Random();
        public static string levelName;

        public static void Initialize(Game1 inputGame)
        {
            game = inputGame;
        }
    }
}
