using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step152
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n                                                        Math App\n=======================================================================================================================");
            Console.WriteLine("Enter a number:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Math.Method1(userNum);
            Math.Method2(userNum);
            Math.Method3(userNum);
            Console.ReadLine();
        }
    }
}
