﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace FNA_game_engine
{
    public class GameHUD
    {
        SpriteFont font;

        public void Load(ContentManager content)
        {
            font = content.Load<SpriteFont>("font\\Arial");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend, SamplerState.LinearClamp, DepthStencilState.Default, RasterizerState.CullNone, null, Resolution.getTransformationMatrix());
            spriteBatch.DrawString(font, "Score: " + Player.score.ToString(), Vector2.Zero, Color.White);
            spriteBatch.End();
        }
    }
}
