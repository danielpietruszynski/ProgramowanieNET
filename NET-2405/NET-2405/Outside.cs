using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_2405
{
    class Outside
    {
        public class Inside
        {
            public void algorytm(float liczba)
            {
                float dok = 0.0000001f;
                
                float x = liczba / 2;
                
                while(Math.Abs(x - (liczba / x)) > dok)
                {
                    x = (x + (liczba / x)) / 2;
                    
                    if (x * x == 2)
                    {
                        Console.WriteLine(x);
                    }
                }
                
                Console.WriteLine(x);
            }
        }
    }
}
