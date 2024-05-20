using rpg_companion.CharModify;
using RPG_Companion;
using rpg_companion.CharModify;
using rpg_companion.WorldStats.RetrieveStats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.Interface
{
    class GenLootUI
    {
        public static void UI()
        {
            string command;
            int lootNumber = 1;
            var lootTypes = new List<string> { "equipment", "weapon", "random" };

            Console.WriteLine("Input Enemy Type: (" + lootTypes[0] + ") - (" + lootTypes[1] + ") - (" + lootTypes[2] + ")");
            command = textModify.toLowerCase(Console.ReadLine());

            Console.WriteLine("Number of selected loot to generate?");
            lootNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (command == lootTypes[0])
            {
                LootGenerator.genLoot.randomLoot(lootNumber);
            }
            else if (command == lootTypes[1])
            {
                LootGenerator.genLoot.randomWeapon(lootNumber);
            }

            //Temporary solution to bias toward weapons and screens. Proper modifiers will be added later.
            else if (command == lootTypes[2])
            {
                for (int i = 0; i < lootNumber; i++)
                {
                    int lootType = mathFunctions.randomNumber(1, 6);
                    switch (lootType)
                    {
                        case 1:
                            LootGenerator.genLoot.randomLoot(1);
                            break;
                        case 2:
                            LootGenerator.genLoot.randomLoot(1);
                            break;
                        case 3:
                            LootGenerator.genLoot.randomLoot(1);
                            break;
                        case 4:
                            LootGenerator.genLoot.randomWeapon(1);
                            break;
                        case 5:
                            LootGenerator.genLoot.randomScreen(1);
                            break;
                        case 6:
                            LootGenerator.genLoot.randomSuit(1);
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Request.");
            }

            Console.WriteLine();

            MainInterface.Main(null);
        }
    }
}