using rpg_companion.CharModify;
using RPG_Companion;
using rpg_companion.CharModify;
using rpg_companion.Enemy.GenEnemy;
using rpg_companion.VehicleGenerator.GenVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.Interface
{
    class GenVehicleUI
    {
        public static void UI()
        {
            string name = "filler";
            string command;
            var vehicleTypes = new List<string> { "land", "air", "random" };

            Console.WriteLine("Input Enemy Type: (" + vehicleTypes[0] + ") - (" + vehicleTypes[1] + ") - (" + vehicleTypes[2] + ")");
            command = textModify.toLowerCase(Console.ReadLine());

            //Command Execution
            if (command == vehicleTypes[0])
            {
                GenVehicle.genLandVehicle();
            }
            else if (command == vehicleTypes[1])
            {
                GenVehicle.genAirVehicle();
            }
            else if (command == vehicleTypes[2])
            {
                int rNum = mathFunctions.randomNumber(1, 2);
                if (rNum == 1)
                {
                    GenVehicle.genLandVehicle();
                }
                else if (rNum == 2)
                {
                    GenVehicle.genAirVehicle();
                }
                else if (rNum == 3)
                {

                }
            }

            Console.WriteLine();

            MainInterface.Main(null);

        }
    }
}