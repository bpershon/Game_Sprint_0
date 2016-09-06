using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace sprint_0
{
    class WorldBackgound : ISprite
    {
        Texture2D Texture;
        int SpriteSheetImageWidth;
        int SpriteSheetImageHeight;
        int OriginX = 0;
        int OriginY = 0;

        public WorldBackgound(ContentManager content)
        {
            this.Texture = content.Load<Texture2D>("super-mario-bros-level-1-1");
            SpriteSheetImageWidth = Texture.Width;
            SpriteSheetImageHeight = Texture.Height;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(OriginX, OriginY, SpriteSheetImageWidth, SpriteSheetImageHeight);
            Rectangle destinationRectangle = new Rectangle(OriginX, OriginY, SpriteSheetImageWidth, SpriteSheetImageHeight);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void Update()
        {
        }
    }
}
