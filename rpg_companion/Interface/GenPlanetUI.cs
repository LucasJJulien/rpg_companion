using rpg_companion.CharModify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace rpg_companion.Interface
{
    class GenPlanetUI
    {
        public static void UI()
        {
            string command;
            string name;
            var planetTypes = new List<string> { "terrestrial", "ice", "water", "desert", "gas giant", "random" };

            Console.WriteLine("Input Planet Type: (" + planetTypes[0] + ") - (" + planetTypes[1] + ") - (" + planetTypes[2] + ") - (" + planetTypes[3] + ") - (" + planetTypes[4] + ")");
            command = textModify.toLowerCase(Console.ReadLine());

            if (planetTypes.Contains(command))
            {
                Console.WriteLine("Name of Planet?");
                name = textModify.toLowerCase(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Invalid Enemy Type.");
            }

            Console.WriteLine();
        }
    }
}
