﻿
using rpg_companion.CharModify;
using rpg_companion.Interface;
using rpg_companion;
using rpg_companion.Enemy.GenEnemy;
using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace RPG_Companion
{
    class MainInterface
    {
        public static void Main(string[] args)
        {

            bool programStatus = true;
            string name = "filler";
            string command;
            var commands = new List<string> { "gen-npc", "gen-loot", "gen-vehicle", "gen-planet", "gen-num", "display-data", "terminate" };


            while (programStatus == true)
            {
                Console.WriteLine("Input Command: (" + commands[0] + ") - (" + commands[1] + ") - (" + commands[2] + ") - (" + commands[3] + ") - (" + commands[4] + ") - (" + commands[5] + ") - (" + commands[6] + ")");
                command = textModify.toLowerCase(Console.ReadLine());

                //Command Execution
                if (command == commands[0])
                {
                    GenEnemyUI.UI();
                }
                else if (command == commands[1])
                {
                    GenLootUI.UI();
                }
                else if (command == commands[2])
                {
                    GenVehicleUI.UI();
                }
                else if (command == commands[3])
                {
                    GenPlanetUI.UI();
                }
                else if (command == commands[4])
                {
                    GenNumUI.UI();
                }
                else if (command == commands[5])
                {

                }
                else if (command == commands.Last())
                {
                    programStatus = false;
                }
                else
                {
                    Console.WriteLine("Invalid Command.");
                }

                Console.WriteLine();

            }


        }


    }

}







