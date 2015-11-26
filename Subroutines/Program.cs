using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subroutines
{
    class Program
    {
        public static void greet()
        {
            Console.WriteLine("Help!, I'm being forced to print text to the screen.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("string[] args = " + args);
            Console.WriteLine();
            greet();
     
            // Program.Main(args); DO NOT UNCOMMENT
            Console.ReadKey();
        }
    }
}
