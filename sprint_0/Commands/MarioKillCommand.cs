namespace Sprint_0
{
    public class MarioKillCommand : ICommand
    {
            private Game1 myGame;

            public MarioKillCommand(Game1 game)
            {
                myGame = game;
            }

            public void Execute()
            {
                myGame.marioSprite = new DeadMarioMovingUpAndDown(myGame.Content);
            }
    }
}
