using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NWW nww = new NWW();

            Console.WriteLine(nww.działanie(15, 60));
            Console.ReadKey();

        }
    }
}
