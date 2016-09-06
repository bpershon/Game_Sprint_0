using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Sprint_0
{
    class WorldBackgound : ISprite
    {
        Texture2D texture;
        int spriteSheetImageWidth;
        int spriteSheetImageHeight;
        int originX = 0;
        int originY = 0;

        public WorldBackgound(ContentManager content)
        {
            this.texture = content.Load<Texture2D>("super-mario-bros-level-1-1");
            spriteSheetImageWidth = texture.Width;
            spriteSheetImageHeight = texture.Height;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(originX, originY, spriteSheetImageWidth, spriteSheetImageHeight);
            Rectangle destinationRectangle = new Rectangle(originX, originY, spriteSheetImageWidth, spriteSheetImageHeight);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void Update()
        {
        }
    }
}
