using rpg_companion.Enemy.GenEnemy;
using rpg_companion.GenerateEnemy;
using rpg_companion.Enemy.GenEnemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpg_companion.WorldStats.RetrieveStats;

namespace rpg_companion.GenerateEnemy
{
    public class Robot : Npc
    {
        public string robotName;
        public string robotType;
        public string level;
        public string program;
        public string body;
        public string movement;
        public Robot(string name)
        {
            robotName = name;
            hp = GenNpcStats.genHp();
            level = GenRobot.genLevel();
            program = GenRobot.genProgram();
            body = GenRobot.genBody();
            movement = GenRobot.genMovement();

            robotType = WorldStats.RetrieveStats.GenRobot.genType();
        }

    }
}