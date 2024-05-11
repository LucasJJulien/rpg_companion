using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.GenerateEnemy
{
    public class Npc
    {
        enum Type
        {
            biological,
            robot
        }
        public string name;
        public int hp;
        public string weapon;
        public string screen;
        public string suit;
    }

}