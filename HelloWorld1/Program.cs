using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");
            Console.Write("What's your name? ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", name);
            Console.ReadLine();
        }
    }
}
