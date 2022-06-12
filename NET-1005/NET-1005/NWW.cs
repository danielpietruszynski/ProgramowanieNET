using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_1005
{
    public class NWW : INWW
    {
        private int _x, _y;

        int INWW.x { get => _x; set => _x = value; }
        int INWW.y { get => _y; set => _y= value; }

        public int działanie(int x, int y)
        {
            int z = x * y;

            if (x != y)
            {
                if (x > y)
                {
                    return działanie(x - y, y);
                }
                else
                {
                    return działanie(x, y - x);
                }
            }
            
            else
            {
                return z / x;
            }
        }
    }
}
