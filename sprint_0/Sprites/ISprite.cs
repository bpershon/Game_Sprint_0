using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace sprint_0
{
    public interface ISprite
    {
        void Update();
        void Draw(SpriteBatch spriteBatch);


    }
}
