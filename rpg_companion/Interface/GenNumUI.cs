using rpg_companion.CharModify;
using rpg_companion.NumberGenerator;
using RPG_Companion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.Interface
{
    class GenNumUI
    {
        public static void UI()
        {
            string command;
            int numOne;
            int numTwo;
            var commands = new List<string> { "gen-number", "d-10"};

            Console.WriteLine("Input Planet Type: (" + commands[0] + ") - (" + commands[1] + ")");

            command = textModify.toLowerCase(Console.ReadLine());

            if (command == commands[0])
            {
                Console.WriteLine("Minimum number:");
                numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Maximum number:");
                numTwo = Convert.ToInt32(Console.ReadLine());
                GenNum.RandomNumber(numOne, numTwo);
            }
            else if (command == commands[1])
            {
                Console.WriteLine("d(?) = 10");
                numOne = Convert.ToInt32(Console.ReadLine());
                GenNum.DTen(numOne);
            }

            Console.WriteLine();
            MainInterface.Main(null);
        }
    }
}
