using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step152
{
    class Math
    {
        public static void Method1(int input)
        {
            int output = input / 2;
            Console.WriteLine("\nHalf of " + input + " is " + output);
        }

        public static void Method2(int input)
        {
            int output = input * 10;
            Console.WriteLine("\n" + input + " multiplied by 10 is " + output);
        }

        public static void Method3(int input)
        {
            int output = input * 3 / 4;
            Console.WriteLine("\nThree quarters of " + input + " is " + output);
        }
    }
}
