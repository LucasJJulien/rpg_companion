using rpg_companion.CharModify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.WorldStats.RetrieveStats
{
    public class GenRobot
    {
        internal static string genType()
        {
            int typeIndex = mathFunctions.randomNumber(0, WorldStats.RobotTypes.robotTypes.Count);
            string type = WorldStats.RobotTypes.robotTypes[typeIndex];
            return type;
        }
    }
}