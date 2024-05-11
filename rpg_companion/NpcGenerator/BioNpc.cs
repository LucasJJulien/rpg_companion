using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpg_companion.Enemy.GenEnemy;
using System.Xml.Linq;
using rpg_companion.Enemy.GenEnemy;

namespace rpg_companion.GenerateEnemy
{
    public class Biological : Npc
    {
        public string race;
        public string gender;
        public Biological(string humanName)
        {
            name = humanName;
            hp = GenNpcStats.genHp();
            race = GenNpcStats.genRace();
            gender = GenNpcStats.genSex();
            weapon = WorldStats.RetrieveStats.GenWeapon.RandomWeapon();
            screen = WorldStats.RetrieveStats.GenScreen.genScreen();
            suit = WorldStats.RetrieveStats.GenSuit.genSuit();
        }
    }
}