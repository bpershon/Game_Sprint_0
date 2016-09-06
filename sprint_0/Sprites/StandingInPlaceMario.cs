using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace sprint_0
{
    public class StandingInPlaceMario : ISprite
    {

        Texture2D Texture;
        int SpriteSheetImageWidth;
        int SpriteSHeetImageHeight;
        int DrawPosX = 400;
        int DrawPosY = 358;
        int OriginX = 0;
        int OriginY = 0;
        int SpriteDrawScale = 2;

        public StandingInPlaceMario(ContentManager content)
        {
            this.Texture = content.Load<Texture2D>("mario_standing");
            SpriteSheetImageWidth = Texture.Width;
            SpriteSHeetImageHeight = Texture.Height;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(OriginX, OriginY, SpriteSheetImageWidth, SpriteSHeetImageHeight);
            Rectangle destinationRectangle = new Rectangle(DrawPosX, DrawPosY, SpriteSheetImageWidth * SpriteDrawScale, SpriteSHeetImageHeight * SpriteDrawScale);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void Update()
        {
        }
    }
}
