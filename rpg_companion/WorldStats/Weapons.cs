using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.WorldStats
{
    public class Weapons
    {
        public int numWeaponTypes = 9;

        public static List<string> laser = new List<string> { "Laser Pistol", "Laser Rifle", "Heavy Laser" };
        public static List<string> sonic = new List<string> { "Sonic Stunner", "Sonic Disruptor", "Sonic Devastator" };
        public static List<string> maser = new List<string> { "Maser Penetrator", "Maser Penetrator 2" };
        public static List<string> shock = new List<string> { "Electrostunner", "Electrodisruptor", "Electrodevastator" };
        public static List<string> gyrojet = new List<string> { "Gyrojet Pistol", "Gyrojet Rifle", "Heavy Laser" };
        public static List<string> proton = new List<string> { "Rafflur M-1", "Rafflur M-2", "Rafflur M-3", "Rafflur M-4", "Rafflur M-6", "Rafflur M-8", "Rafflur M-10" };
        public static List<string> bolt = new List<string> { "WarTech Alpha-Bolt", "WarTech Omega-Bolt", "Heavy Laser" };
        public static List<string> projectile = new List<string> { "Pistol", "Automatic Pistol", "Rifle", "Automatic Rifle", "Machine Gun" };

        public static List<string> melee = new List<string> { "Sonic Knife", "Sonic Sword", "Heavy Laser", "Electric Lance", "Electric Sword", "Stunstick" };



    }
}