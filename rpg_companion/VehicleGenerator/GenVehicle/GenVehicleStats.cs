using rpg_companion.CharModify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.VehicleGenerator.GenVehicle
{
    public class GenVehicleStats
    {
        internal static int genHpPercent()
        {
            int hpPercent = mathFunctions.randomNumber(0, 100);
            return hpPercent;
        }

        internal static int genBatteryPercent()
        {
            int batteryPercent = mathFunctions.randomNumber(0, 100);
            return batteryPercent;
        }
        internal static string genLandType()
        {
            int landTypeIndex = mathFunctions.randomNumber(0, WorldStats.Vehicles.landVehicles.Count);
            string landType = WorldStats.Vehicles.landVehicles[landTypeIndex];
            return landType;
        }
        internal static string genAirType()
        {
            int airTypeIndex = mathFunctions.randomNumber(0, WorldStats.Vehicles.airVehicles.Count);
            string airType = WorldStats.Vehicles.airVehicles[airTypeIndex];
            return airType;
        }
    }
}