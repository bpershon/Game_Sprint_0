using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace sprint_0
{
    public class DeadMarioMovingUpAndDown : ISprite
    {
        Texture2D Texture;
        int SpriteSheetImageWidth;
        int SpriteSheetImageHeight;
        int DrawPosX = 400;
        int DrawPosY = 358;
        int OriginX = 0;
        int OriginY = 0;
        int SpriteDrawScale = 2;
        bool ReachedMaxYCoord = false;
        int MaxYCoord = 200;
        int CurrentYCoord;

        public DeadMarioMovingUpAndDown(ContentManager content)
        {
            this.Texture = content.Load<Texture2D>("mario_dead");
            SpriteSheetImageWidth = Texture.Width; 
            SpriteSheetImageHeight = Texture.Height;
            CurrentYCoord = DrawPosY;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(OriginX, OriginY, SpriteSheetImageWidth, SpriteSheetImageHeight);
            Rectangle destinationRectangle = new Rectangle(DrawPosX, CurrentYCoord, SpriteSheetImageWidth * SpriteDrawScale, SpriteSheetImageHeight * SpriteDrawScale);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void Update()
        {
            if (CurrentYCoord == MaxYCoord)
            {
                ReachedMaxYCoord = true;
            }
            else if (CurrentYCoord == DrawPosY)
            {
                ReachedMaxYCoord = false;
            }

            if (ReachedMaxYCoord)
            {
                CurrentYCoord++;
            }
            else
            {
                CurrentYCoord--;
            }
        }
    }
}
