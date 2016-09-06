using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Sprint_0
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;
        Game1 myGame;

        public KeyboardController(Game1 game)
        {
            myGame = game;
            controllerMappings = new Dictionary<Keys, ICommand>();
            RegisterCommand();
        }

        public void RegisterCommand()
        {
            controllerMappings.Add(Keys.Q, new MarioQuitCommand(myGame));
            controllerMappings.Add(Keys.W, new MarioStandStillCommand(myGame));
            controllerMappings.Add(Keys.E, new MarioRunningInPlaceCommand(myGame));
            controllerMappings.Add(Keys.R, new MarioKillCommand(myGame));
            controllerMappings.Add(Keys.T, new MarioRunningLeftCommand(myGame));
        }

        public void Update()
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();

            foreach (Keys key in pressedKeys)
            {
                if (controllerMappings.ContainsKey(key))
                {
                    controllerMappings[key].Execute();
                }
            }
        }
    }
}
