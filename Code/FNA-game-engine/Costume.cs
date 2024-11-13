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
using Microsoft.SqlServer.Server;
using System.Web;
using System.Xml.Linq;

namespace FNA_game_engine
{
    public class Costume : GameObject
    {
        public string name = "new costume";
        public int offSetX = 0;
        public int offSetY = 0;
        enum Costumes
        {
            hat,
        };

        public GameObject sourceObject;

        public Costume()
        {

        }
        public override void Update(List<GameObject> objects, Map map)
        {
            /*
             * 
             * HERE
             * 
             * VVVV*/

            if (sourceObject is Player)
            {

            }
            position = GetOffSet(sourceObject.position);
        }

        public Vector2 GetOffSet(Vector2 sourcePos)
        {
            sourcePos.X += offSetX;
            sourcePos.Y += offSetY;
            return sourcePos;
        }
        public Costume(GameObject source, string costumeName)
        {
            name = "hat";
            layerDepth = 0.49f;
            sourceObject = source;
            position = sourceObject.position;
            offSetX = 16;
            offSetY = 2;
        }
        public override void Load(ContentManager content)
        {
            image = TextureLoader.Load(name, content);

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (image != null)
            {
                spriteBatch.Draw(image, position, null, drawColor, MathHelper.ToRadians(rotation), Vector2.Zero, scale, SpriteEffects.None, layerDepth);
            }
        }
    }
}
