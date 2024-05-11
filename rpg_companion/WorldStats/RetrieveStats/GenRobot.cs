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
            int typeIndex = mathFunctions.randomNumber(0, WorldStats.Robots.robotTypes.Count);
            string type = WorldStats.Robots.robotTypes[typeIndex];
            return type;
        }
        internal static string genLevel()
        {
            int levelIndex = mathFunctions.randomNumber(0, WorldStats.Robots.level.Count);
            string level = WorldStats.Robots.level[levelIndex];
            return level;
        }
        internal static string genProgram()
        {
            int programIndex = mathFunctions.randomNumber(0, WorldStats.Robots.program.Count);
            string program = WorldStats.Robots.program[programIndex];
            return program;
        }
        internal static string genBody()
        {
            int bodyIndex = mathFunctions.randomNumber(0, WorldStats.Robots.body.Count);
            string body = WorldStats.Robots.body[bodyIndex];
            return body;
        }
        internal static string genMovement()
        {
            int movementIndex = mathFunctions.randomNumber(0, WorldStats.Robots.movement.Count);
            string movement = WorldStats.Robots.movement[movementIndex];
            return movement;
        }
    }
}