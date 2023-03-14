using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace D14_AdvancedExtension
{
    internal static class IntExtensionMethods
    {


        internal static int MyAdd(this int num1, int num2, int num3)
        {
            return (num1 + num2) + num3;
        }

        internal static int MySubtract(this int num1, int num2)
        {
            return (num1 - num2);
        }


        internal static int MyMultiply(this int num1, int num2)
        {
            return (num1 * num2);
        }

        internal static int MyDivide(this int num1, int num2)
        {
            return (num1 / num2);
        }
    }
}
