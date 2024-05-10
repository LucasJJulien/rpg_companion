using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_companion.CharModify
{
    public class textModify
    {
        internal static string toLowerCase(string text)
        {
            text = Convert.ToString(text.ToLower());
            return text;
        }

        internal static string toUpperCase(string text)
        {
            text = Convert.ToString(text.ToUpper());
            return text;
        }
    }
}