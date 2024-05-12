using rpg_companion.CharModify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.WorldStats.RetrieveStats
{
    public class GenEquipment
    {

        internal static string genRandomEquipment()
        {
            int equipmentType = mathFunctions.randomNumber(1, 7);
            switch (equipmentType)
            {
                case 1:
                    return (genGeneral());
                    break;
                case 2:
                    return (genSurvival());
                    break;
                case 3:
                    return (genMedical());
                    break;
                case 4:
                    return (genAmmo());
                    break;
                case 5:
                    return (genKits());
                    break;
                case 6:
                    return (genAmmo());
                    break;
                case 7:
                    return (genGrenades());
                    break;
                default:
                    return ("Request failed.");
                    break;
            }
        }

        internal static string genGeneral()
        {
            int generalIndex = mathFunctions.randomNumber(0, WorldStats.Equipment.general.Count);
            string general = WorldStats.Equipment.general[generalIndex];
            return general;
        }

        internal static string genSurvival()
        {
            int survivalIndex = mathFunctions.randomNumber(0, WorldStats.Equipment.survival.Count);
            string survival = WorldStats.Equipment.survival[survivalIndex];
            return survival;
        }

        internal static string genMedical()
        {
            int medicalIndex = mathFunctions.randomNumber(0, WorldStats.Equipment.medical.Count);
            string medical = WorldStats.Equipment.medical[medicalIndex];
            return medical;
        }

        internal static string genPower()
        {
            int powerIndex = mathFunctions.randomNumber(0, WorldStats.Equipment.power.Count);
            string power = WorldStats.Equipment.power[powerIndex];
            return power;
        }

        internal static string genAmmo()
        {
            int ammoIndex = mathFunctions.randomNumber(0, WorldStats.Equipment.ammunition.Count);
            string power = WorldStats.Equipment.ammunition[ammoIndex];
            return power;
        }
        internal static string genGrenades()
        {
            int grenadesIndex = mathFunctions.randomNumber(0, WorldStats.Equipment.grenades.Count);
            string grenades = WorldStats.Equipment.grenades[grenadesIndex];
            return grenades;
        }

        internal static string genKits()
        {
            int kitsIndex = mathFunctions.randomNumber(0, WorldStats.Equipment.kits.Count);
            string kits = WorldStats.Equipment.kits[kitsIndex];
            return kits;
        }
    }
}