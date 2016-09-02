using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace sprint_0
{
    class WorldBackgound : ISprite
    {

        public Texture2D Texture { get; set; }

        public WorldBackgound(Texture2D texture)
        {
            Texture = texture;

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            int imageWidth = Texture.Width; // Columns;
            int imageHeight = Texture.Height; // Rows;
            int originX = 0;
            int originY = 0;
            Rectangle sourceRectangle = new Rectangle(originX, originY, imageWidth, imageHeight);
            Rectangle destinationRectangle = new Rectangle(originX, originY, imageWidth, imageHeight);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void Update()
        {
        }
    }
}
