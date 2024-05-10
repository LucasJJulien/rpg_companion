using rpg_companion.CharModify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.WorldStats.RetrieveStats
{
    public class GenScreen
    {
        internal static string genScreen()
        {
            int screensIndex = mathFunctions.randomNumber(0, WorldStats.Screens.screens.Count);
            string screen = WorldStats.Screens.screens[screensIndex];
            return screen;
        }
    }
}