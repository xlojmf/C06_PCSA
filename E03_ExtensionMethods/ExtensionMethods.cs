using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_ExtensionMethods
{
    internal static class ExtensionMethods
    {

        internal static string ConcaterParaMaiusculas(this string text1, string text2)
        {
            
            return $"{text1} {text2.ToUpper()}";

        }

        internal static string FormatarParaEuro(this string text1)
        {
            return $"{text1} £";
        }

        internal static string FormatarParaEuro(this int text1)
        {
            return $"{text1} £";
        }


        internal static string FormatarParaEuro(this object value)
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("pt-PT");
            double doubleValue;
            if (double.TryParse(value.ToString(), NumberStyles.Any, culture, out doubleValue))
            {
                return doubleValue.ToString("C", culture);
            }
            return $"{value} £";
        }






    }
}
