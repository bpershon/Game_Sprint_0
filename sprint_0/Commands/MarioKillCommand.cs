using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint_0
{
    public class MarioKillCommand : ICommand
    {
            private Game1 MyGame;

            public MarioKillCommand(Game1 game)
            {
                MyGame = game;
            }

            public void Execute()
            {
                MyGame.MarioSprite = new DeadMarioMovingUpAndDown(MyGame.Content);
            }
    }
}
