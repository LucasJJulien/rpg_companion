﻿using rpg_companion.CharModify;
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
            var lootTypes = new List<string> { "equipment", "weapon", "screen", "suit", "random" };

            Console.WriteLine("Input Enemy Type: (" + lootTypes[0] + ") - (" + lootTypes[1] + ") - (" + lootTypes[2] + ") - (" + lootTypes[3] + ") - (" + lootTypes[4] + ")");
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
            else if (command == lootTypes[2])
            {
                LootGenerator.genLoot.randomScreen(lootNumber);
            }
            else if (command == lootTypes[3])
            {
                LootGenerator.genLoot.randomSuit(lootNumber);
            }
            else if (command == lootTypes[4])
            {

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