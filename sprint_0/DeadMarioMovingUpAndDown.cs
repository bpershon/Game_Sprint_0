using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace sprint_0
{
    public class DeadMarioMovingUpAndDown : ISprite
    {

        private Texture2D Texture { get; }
        int imageWidth;// Columns;
        int imageHeight;// Rows;
        int xCoord = 400;
        static int yCoord = 358;
        int originX = 0;
        int originY = 0;
        int scale = 2;
        //animation variables
        bool reachedMaxYCoord = false;
        int maxYCoord = 200;
        int currentYCord = yCoord;

        public DeadMarioMovingUpAndDown(Texture2D texture)
        {
            Texture = texture;
            imageWidth = Texture.Width; 
            imageHeight = Texture.Height;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(originX, originY, imageWidth, imageHeight);
            Rectangle destinationRectangle = new Rectangle(xCoord, currentYCord, imageWidth * scale, imageHeight * scale);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void Update()
        {
            if (currentYCord == maxYCoord)
            {
                reachedMaxYCoord = true;
            }
            else if (currentYCord == yCoord)
            {
                reachedMaxYCoord = false;
            }

            if (reachedMaxYCoord)
            {
                currentYCord++;
            }
            else
            {
                currentYCord--;
            }
        }
    }
}
