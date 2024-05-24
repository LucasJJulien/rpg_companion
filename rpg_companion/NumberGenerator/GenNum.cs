using rpg_companion.CharModify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.NumberGenerator
{
    public class GenNum
    {
        
        public static void RandomNumber(int minMum, int maxNum)
        {
            int num = mathFunctions.randomNumber(minMum, maxNum);
            Console.WriteLine(num);
        }

        public static void DTen(int d)
        {
            int numOne;
            int finalNum = 0;

            for (int i = 0; i < d; i++)
            {
                numOne = mathFunctions.randomNumber(1, 10);
                finalNum += numOne;
                Console.Write(numOne + " - ");
            }
            Console.Write("End.");
            Console.WriteLine();

            Console.WriteLine("Final Number: " + finalNum);
        }
    }
}
