using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint_0
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public ISprite MarioSprite;
        private ISprite BackgroundSprite;
        private IController KeyboardController;
        private IController GamePadController;
        private ICommand MarioCommand;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            MarioCommand = new MarioQuitCommand(this);
            //KeyboardController.RegisterCommand(Keys.Q, MarioCommand);
            //KeyboardController.RegisterCommand(Keys.W, MarioCommand); //Stand still
            //KeyboardController.RegisterCommand(Keys.E, MarioCommand); //Running 
            //KeyboardController.RegisterCommand(Keys.R, MarioCommand); //Dead
            //KeyboardController.RegisterCommand(Keys.T, MarioCommand); //Leftandrgh
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            BackgroundSprite = new WorldBackgound(this.Content);
            MarioSprite = new StandingInPlaceMario(this.Content);
            MarioCommand = new MarioQuitCommand(this);
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            MarioSprite.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            BackgroundSprite.Draw(spriteBatch);
            MarioSprite.Draw(spriteBatch);
            base.Draw(gameTime);
        }
    }
}
