﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace sprint_0
{
    public class RunningInPlaceMario : ISprite
    {
        Texture2D Texture;
        int SpriteSheetImageWidth;
        int SpriteSheetImageHeight;
        int DrawPosX = 400;
        int DrawPosY = 358;
        int OriginX = 0;
        int OriginY = 0;
        int SpriteDrawScale = 2;
        int TotalSpriteFrames = 2;
        int CurrentSpriteFrame;
        int UpdateSpriteAnimation;
        int UpdateSpriteAnimationThreshold = 3;

        public RunningInPlaceMario(ContentManager content)
        {
            this.Texture = content.Load<Texture2D>("mario_running_inplace");
            SpriteSheetImageWidth = Texture.Width / TotalSpriteFrames;
            SpriteSheetImageHeight = Texture.Height;
            CurrentSpriteFrame = 0;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            int column = CurrentSpriteFrame % TotalSpriteFrames;
            Rectangle sourceRectangle = new Rectangle(SpriteSheetImageWidth * column, OriginY, SpriteSheetImageWidth, SpriteSheetImageHeight);
            Rectangle destinationRectangle = new Rectangle(DrawPosX, DrawPosY, SpriteSheetImageWidth * SpriteDrawScale, SpriteSheetImageHeight * SpriteDrawScale);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void Update()
        {
            UpdateSpriteAnimation++;
            if (UpdateSpriteAnimation == UpdateSpriteAnimationThreshold)
            {
                UpdateSpriteAnimation = 0;
                CurrentSpriteFrame++;
                if (CurrentSpriteFrame == TotalSpriteFrames)
                    CurrentSpriteFrame = 0;
            }

        }
    }
}

