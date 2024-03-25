using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poznamky2ITB
{
    public static class Extensions
    {
        public static String ToHex(this Color c)
        { 
            return $"#{c.R:X2}{c.G:X2}{c.B:X2}"; 
        }


        public static Color ToColor(this string str)
        {
            return ColorTranslator.FromHtml(str);
        } 
    }
}
