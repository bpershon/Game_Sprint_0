using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace Sprint_0
{
    public class GamepadController : IController
    {
        private Dictionary<Buttons, ICommand> controllerMappings;
        Game1 myGame;
        GamePadState currentGamepadState;

        public GamepadController(Game1 game)
        {
            myGame = game;
            controllerMappings = new Dictionary<Buttons, ICommand>();
            currentGamepadState = new GamePadState();
            RegisterCommand();
        }

        public void RegisterCommand()
        {
            controllerMappings.Add(Buttons.Start, new MarioQuitCommand(myGame));
            controllerMappings.Add(Buttons.A, new MarioStandStillCommand(myGame));
            controllerMappings.Add(Buttons.B, new MarioRunningInPlaceCommand(myGame));
            controllerMappings.Add(Buttons.X, new MarioKillCommand(myGame));
            controllerMappings.Add(Buttons.Y, new MarioRunningLeftCommand(myGame));
        }

        public void Update()
        {
            currentGamepadState = GamePad.GetState(PlayerIndex.One);
            if(currentGamepadState.Buttons.Start == ButtonState.Pressed)
            {
                controllerMappings[Buttons.Start].Execute();
            }
            else if(currentGamepadState.Buttons.A == ButtonState.Pressed)
            {
                controllerMappings[Buttons.A].Execute();
            }
            else if (currentGamepadState.Buttons.B == ButtonState.Pressed)
            {
                controllerMappings[Buttons.B].Execute();
            }
            else if (currentGamepadState.Buttons.X == ButtonState.Pressed)
            {
                controllerMappings[Buttons.X].Execute();
            }
            else if (currentGamepadState.Buttons.Y == ButtonState.Pressed)
            {
                controllerMappings[Buttons.Y].Execute();
            }
        }
    }
}
