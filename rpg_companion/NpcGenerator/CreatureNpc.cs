using rpg_companion.Enemy.GenEnemy;
using rpg_companion.WorldStats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace rpg_companion.GenerateEnemy
{
    public class Creature : Npc
    {
        public string creatureType;
        public Creature(string creatureName)
        {
            name = creatureName;
            hp = GenNpcStats.genHp();
            creatureType = GenNpcStats.genCreatureType();
        }
    }
}