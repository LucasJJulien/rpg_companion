using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.VehicleGenerator
{
    public class Vehicle
    {
        enum Type
        {
            land,
            air
        }

        public string vehicleType;
        public string vehicleModel;
        public int batteryPercent;
        public int healthPercent;
        public string screen;

    }

}