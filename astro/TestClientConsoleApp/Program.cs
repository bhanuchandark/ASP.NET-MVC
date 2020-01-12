using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClientConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.MathServices proxy = new localhost.MathServices();
            Console.Write("2 + 4 = {0}", proxy.Add(2, 4));
            Console.ReadLine();
        }
    }
}
