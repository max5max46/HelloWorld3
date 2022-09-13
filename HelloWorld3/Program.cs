using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int looop = 0; looop < 1000000; looop++)
            {
                Console.WriteLine("Hello World! x" + looop);
            }
            
        }
    }
}
