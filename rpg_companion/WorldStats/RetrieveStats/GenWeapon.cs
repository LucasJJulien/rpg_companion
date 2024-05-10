using rpg_companion.CharModify;
using rpg_companion.WorldStats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.WorldStats.RetrieveStats
{
    public class GenWeapon
    {
        internal static string RandomWeapon()
        {

            int weaponType = mathFunctions.randomNumber(1, 9);

            switch (weaponType)
            {
                case 1:
                    return (genLaser());
                    break;
                case 2:
                    return (genSonic());
                    break;
                case 3:
                    return (genMaser());
                    break;
                case 4:
                    return (genShock());
                    break;
                case 5:
                    return (genGyroJet());
                    break;
                case 6:
                    return (genProton());
                    break;
                case 7:
                    return (genBolt());
                    break;
                case 8:
                    return (genProjectile());
                    break;
                case 9:
                    return (genMelee());
                    break;
                default:
                    return ("Request Failed.");
                    break;
            }


        }

        internal static string genLaser()
        {
            int laserIndex = mathFunctions.randomNumber(0, Weapons.laser.Count);
            string laser = Weapons.laser[laserIndex];
            return laser;
        }
        internal static string genSonic()
        {
            int sonicIndex = mathFunctions.randomNumber(0, Weapons.sonic.Count);
            string sonic = Weapons.sonic[sonicIndex];
            return sonic;
        }
        internal static string genMaser()
        {
            int maserIndex = mathFunctions.randomNumber(0, Weapons.maser.Count);
            string maser = Weapons.maser[maserIndex];
            return maser;
        }
        internal static string genShock()
        {
            int shockIndex = mathFunctions.randomNumber(0, Weapons.shock.Count);
            string shock = Weapons.shock[shockIndex];
            return shock;
        }
        internal static string genGyroJet()
        {
            int gyrojetIndex = mathFunctions.randomNumber(0, Weapons.gyrojet.Count);
            string gyrojet = Weapons.gyrojet[gyrojetIndex];
            return gyrojet;
        }
        internal static string genProton()
        {
            int protonIndex = mathFunctions.randomNumber(0, Weapons.proton.Count);
            string proton = Weapons.proton[protonIndex];
            return proton;
        }
        internal static string genBolt()
        {
            int boltIndex = mathFunctions.randomNumber(0, Weapons.bolt.Count);
            string bolt = Weapons.bolt[boltIndex];
            return bolt;
        }
        internal static string genProjectile()
        {
            int projectileIndex = mathFunctions.randomNumber(0, Weapons.projectile.Count);
            string projectile = Weapons.projectile[projectileIndex];
            return projectile;
        }
        internal static string genMelee()
        {
            int meleeIndex = mathFunctions.randomNumber(0, Weapons.melee.Count);
            string melee = Weapons.melee[meleeIndex];
            return melee;
        }
    }
}