using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_2405
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Outside.Inside inside = new Outside.Inside();
            inside.algorytm(3);
            Console.ReadKey();
        }
    }
}
