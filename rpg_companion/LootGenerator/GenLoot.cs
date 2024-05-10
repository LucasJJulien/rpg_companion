using rpg_companion.WorldStats.RetrieveStats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.LootGenerator
{
    public class genLoot
    {
        public static void randomLoot(int numLoot)
        {
            string loot;
            for (int i = 0; i < numLoot; i++)
            {
                loot = GenEquipment.genRandomEquipment();
                Console.WriteLine(loot);
            }
        }

        public static void randomWeapon(int numLoot)
        {
            string loot;
            for (int i = 0; i < numLoot; i++)
            {
                loot = GenWeapon.RandomWeapon();
                Console.WriteLine(loot);
            }
        }

        public static void randomScreen(int numLoot)
        {
            string loot;
            for (int i = 0; i < numLoot; i++)
            {
                loot = GenScreen.genScreen();
                Console.WriteLine(loot);
            }
        }

        public static void randomSuit(int numLoot)
        {
            string loot;
            for (int i = 0; i < numLoot; i++)
            {
                loot = GenSuit.genSuit();
                Console.WriteLine(loot);
            }
        }
    }
}