using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint_0
{
    class MarioRunningLeftCommand : ICommand
    {
        private Game1 MyGame;

        public MarioRunningLeftCommand(Game1 game)
        {
            MyGame = game;
        }

        public void Execute()
        {
            MyGame.MarioSprite = new RunningLeftMario(MyGame.Content);
        }
    }
}
