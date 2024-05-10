using rpg_companion.GenerateEnemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.VehicleGenerator.GenVehicle
{
    public class GenVehicle
    {
        public static void genLandVehicle()
        {
            Land Vehicle = new Land();

            Console.WriteLine();
            Console.WriteLine("Type: " + Vehicle.vehicleType);
            Console.WriteLine("Model: " + Vehicle.vehicleModel);
            Console.WriteLine("Battery Percentage: " + Vehicle.batteryPercent);
            Console.WriteLine("Health Percentage: " + Vehicle.healthPercent);
            Console.WriteLine();
        }

        public static void genAirVehicle()
        {
            Air Vehicle = new Air();

            Console.WriteLine();
            Console.WriteLine("Type: " + Vehicle.vehicleType);
            Console.WriteLine("Model: " + Vehicle.vehicleModel);
            Console.WriteLine("Battery Percentage: " + Vehicle.batteryPercent);
            Console.WriteLine("Health Percentage: " + Vehicle.healthPercent);
            Console.WriteLine();
        }
    }
}