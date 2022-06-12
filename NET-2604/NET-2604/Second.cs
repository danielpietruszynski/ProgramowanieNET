using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_2604
{
    public class Second : First
    {
        public override void f()
        {
            Console.WriteLine("Sprawdzam działanie");
        }
        public override string r()
        {
            return "Jestem drugą klasą";
        }
    }
}
