using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.WorldStats
{
    public class Robots
    {

        public static List<string> robotTypes = new List<string> { "Combat", "Cybernetic", "Heavy Duty", "Maintenence", "Security", "Service", "Warbot" };
        public static List<string> level = new List<string> { "Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6"};
        public static List<string> program = new List<string> { "Security Lock", "Restrain", "Self Defense", "Attack/Defense", "Search and Destroy", "Computer Link", "Bio-electric Circuits" };
        public static List<string> body = new List<string> { "Light", "Standard", "Heavy Duty", "Anthropomorphic"};
        public static List<string> movement = new List<string> { "Basic", "Altered"};

    }
}