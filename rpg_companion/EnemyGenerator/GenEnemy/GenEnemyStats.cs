using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpg_companion.CharModify;
using rpg_companion.CharModify;

namespace rpg_companion.Enemy.GenEnemy
{
    public class genEnemyStats
    {
        internal static int genHp()
        {
            int hp = mathFunctions.randomNumber(20, 80);
            return hp;
        }

        internal static string genRace()
        {
            int raceIndex = mathFunctions.randomNumber(0, WorldStats.Races.races.Count);
            string race = WorldStats.Races.races[raceIndex];
            return race;
        }

        internal static string genSex()
        {
            int genderIndex = mathFunctions.randomNumber(0, WorldStats.Sex.sex.Count);
            string gender = WorldStats.Sex.sex[genderIndex];
            return gender;
        }

        internal static string genCreatureType()
        {
            int creatureTypeIndex = mathFunctions.randomNumber(0, WorldStats.Creatures.creatures.Count);
            string creature = WorldStats.Suits.suits[creatureTypeIndex];
            return creature;
        }


        /*
        internal static string genEquipment()
        {
            int numEquipment = mathFunctions.randomNumber(0, 3);
            foreach()
            {

            }
            return ();
        }
        */

    }




}