using rpg_companion.CharModify;
using rpg_companion.Enemy.GenEnemy;
using RPG_Companion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.Interface
{
    class GenEnemyUI
    {
        public static void UI()
        {
            string name = "filler";
            string command;
            var enemyTypes = new List<string> { "biological", "robot", "creature", "random" };

            Console.WriteLine("Input Enemy Type: (" + enemyTypes[0] + ") - (" + enemyTypes[1] + ") - (" + enemyTypes[2] + ") - (" + enemyTypes[3] + ")");
            command = textModify.toLowerCase(Console.ReadLine());

            if (enemyTypes.Contains(command))
            {
                Console.WriteLine("Name of Enemy?");
                name = textModify.toLowerCase(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Invalid Enemy Type.");
            }

            //Command Execution
            if (command == enemyTypes[0])
            {
                GenNpc.genHuman(name);
            }
            else if (command == enemyTypes[1])
            {
                GenNpc.genRobot(name);
            }
            else if (command == enemyTypes[2])
            {
                GenNpc.genCreature(name);
            }
            else if (command == enemyTypes[3])
            {
                int rNum = mathFunctions.randomNumber(1, 3);
                if (rNum == 1)
                {
                    GenNpc.genHuman(name);
                }
                else if (rNum == 2)
                {
                    GenNpc.genRobot(name);
                }
                else if (rNum == 3)
                {
                    GenNpc.genCreature(name);
                }
            }

            Console.WriteLine();

            MainInterface.Main(null);

        }
    }

}