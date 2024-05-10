using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.CharModify
{

    public class mathFunctions
    {

        internal static int randomNumber(int minNumber, int maxNumber)
        {
            int number;
            Random rnd = new Random();


            number = rnd.Next(minNumber, maxNumber);
            return number;
        }

    }

}