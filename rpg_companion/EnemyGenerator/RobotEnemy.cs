using rpg_companion.Enemy.GenEnemy;
using rpg_companion.GenerateEnemy;
using rpg_companion.Enemy.GenEnemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.GenerateEnemy
{
    public class Robot : Enemy
    {
        public string robotType;
        public Robot(string robotName)
        {
            hp = genEnemyStats.genHp();
            robotType = WorldStats.RetrieveStats.GenRobot.genType();
        }

    }
}