using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace sprint_0
{
    public class StandingInPlaceMario : ISprite
    {

        private Texture2D Texture { get; }
        int imageWidth;// Columns;
        int imageHeight;// Rows;
        int xCoord = 400;
        int yCoord = 358;
        int originX = 0;
        int originY = 0;
        int scale = 2;

        public StandingInPlaceMario(Texture2D texture)
        {
            Texture = texture;
            imageWidth = Texture.Width;
            imageHeight = Texture.Height;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(originX, originY, imageWidth, imageHeight);
            Rectangle destinationRectangle = new Rectangle(xCoord, yCoord, imageWidth * scale, imageHeight * scale);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void Update()
        {

        }
    }
}
