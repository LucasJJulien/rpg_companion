using rpg_companion.CharModify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.WorldStats.RetrieveStats
{
    public class GenSuit
    {
        internal static string genSuit()
        {
            int suitsIndex = mathFunctions.randomNumber(0, WorldStats.Suits.suits.Count);
            string suit = WorldStats.Suits.suits[suitsIndex];
            return suit;
        }
    }
}