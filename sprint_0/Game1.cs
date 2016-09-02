using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint_0
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private ISprite mario;
        private ISprite background; 

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            Texture2D WorldBackground = Content.Load<Texture2D>("super-mario-bros-level-1-1");
            Texture2D StandingMaroTexture = Content.Load<Texture2D>("mario_standing");
            Texture2D RunningInPlaceMarioTexture = Content.Load<Texture2D>("mario_running_inplace");
            Texture2D DeadMarioMovingUpAndDownTexture = Content.Load<Texture2D>("mario_dead");
            //Texture2D RunningLeftAndRightMariortexture = Content.Load<Texture2D>("mario_running");
            background = new WorldBackgound(WorldBackground);
            //mario = new StandingInPlaceMario(StandingMaroTexture); WORKING
            //mario = new DeadMarioMovingUpAndDown(DeadMarioMovingUpAndDownTexture); WORKING
            mario = new RunningInPlaceMario(RunningInPlaceMarioTexture);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            mario.Update();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            //GraphicsDevice.Clear(Color.CornflowerBlue); REMOVEME I AM A REFERENCE

            // TODO: Add your drawing code here
            background.Draw(spriteBatch);
            mario.Draw(spriteBatch);

            base.Draw(gameTime);
        }
    }
}
