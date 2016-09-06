namespace Sprint_0
{
    class MarioStandStillCommand : ICommand
    {
        private Game1 myGame;

        public MarioStandStillCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.marioSprite = new StandingInPlaceMario(myGame.Content);
        }
    }
}
