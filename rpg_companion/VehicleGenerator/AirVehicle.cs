using rpg_companion.VehicleGenerator.GenVehicle;
using rpg_companion.VehicleGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace rpg_companion.VehicleGenerator
{
    public class Air : Vehicle
    {

        public Air()
        {
            vehicleType = "Air";
            batteryPercent = GenVehicleStats.genBatteryPercent();
            healthPercent = GenVehicleStats.genHpPercent();
            vehicleModel = GenVehicleStats.genAirType();

        }
    }
}