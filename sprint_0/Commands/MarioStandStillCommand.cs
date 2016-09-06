using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint_0
{
    class MarioStandStillCommand : ICommand
    {
        private Game1 MyGame;

        public MarioStandStillCommand(Game1 game)
        {
            MyGame = game;
        }

        public void Execute()
        {
            MyGame.MarioSprite = new StandingInPlaceMario(MyGame.Content);
        }
    }
}
