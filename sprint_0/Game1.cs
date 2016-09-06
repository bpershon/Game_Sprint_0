using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections;

namespace Sprint_0
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public ISprite marioSprite;
        private ISprite backgroundSprite;
        ArrayList controllerList;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            controllerList = new ArrayList();
            controllerList.Add(new KeyboardController(this));
            controllerList.Add(new GamepadController(this));         
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            backgroundSprite = new WorldBackgound(this.Content);
            marioSprite = new StandingInPlaceMario(this.Content);

        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllerList)
            {
                controller.Update();
            }
            marioSprite.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            backgroundSprite.Draw(spriteBatch);
            marioSprite.Draw(spriteBatch);
            base.Draw(gameTime);
        }
    }
}
