using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class HandBrake : IBreaker
    {
        public void Breaking()
        {
            Console.WriteLine("Ручной тормоз");
        }
    }
}
