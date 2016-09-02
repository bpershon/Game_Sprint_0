using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace sprint_0
{
    public class RunningInPlaceMario : ISprite
    {


        private Texture2D Texture { get; }
        int imageWidth;// Columns;
        int imageHeight;// Rows;
        int xCoord = 400;
        int yCoord = 358;
        int originX = 0;
        int originY = 0;
        int scale = 2;
        //Animation variables
        int curretFrame = 1;
        int totalFrame = 2;

        public RunningInPlaceMario(Texture2D texture)
        {
            Texture = texture;
            imageWidth = Texture.Width / 2;
            imageHeight = Texture.Height;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            int column = curretFrame % totalFrame;
            Rectangle sourceRectangle = new Rectangle(originX * column, originY, imageWidth, imageHeight);
            Rectangle destinationRectangle = new Rectangle(xCoord, yCoord, imageWidth * scale, imageHeight * scale);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void Update()
        {
            curretFrame++;
            if (curretFrame == totalFrame)
                curretFrame = 0;
        }
    }
}
