using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.WorldStats
{
    public class Equipment
    {

        public static List<string> general = new List<string> { "Magnigoggles", "Portable Welder", "Spacesuit", "Sungoggles", "Gas Mask", "Helmet", "Infared Goggles", "Intercom"};
        public static List<string> survival = new List<string> { "Allweather Blanket", "Allweather Matches", "Chronocom", "Compass", "Emergency Beacon", "Everflame", "Flashlight", "Life Jacket", "Rope", "Survival Rations", "Toxyrad Guage", "Vitasalt Pills", "Water Pack" };
        public static List<string> medical = new List<string> { "Stimdose", "medkit", "First Aid Pack", "Spray Hypo", "Sonic Scalpel", "Medscanner", "Antiseptic" };
        public static List<string> power = new List<string> { "Power Backpack", "Power Beltpack", "Power Econopack", "Powerclip", "Powerpack" };
        public static List<string> ammunition = new List<string> { "Standard Ammunition", "Explosive Rounds", "Incendiary Rounds", "Poison Rounds"};
        public static List<string> grenades = new List<string> { "EMP Grenade", "Explosive Grenade", "Fragmentation Grenade", "Incendiary Grendade", "Smoke Grenade", "Gas Grenade", "Stun Grenade"};
        public static List<string> kits = new List<string> { "Envirokit", "Radscanner", "Robcom Kit", "Standard Equipment Pack", "Survival Kit Gear", "Techkit" };

    }
}