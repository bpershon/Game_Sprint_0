using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint_0
{
    public class MarioRunningInPlaceCommand : ICommand
    {
        private Game1 MyGame;

        public MarioRunningInPlaceCommand(Game1 game)
        {
            MyGame = game;
        }

        public void Execute()
        {
            MyGame.MarioSprite = new RunningInPlaceMario(MyGame.Content);
        }
    }
}
