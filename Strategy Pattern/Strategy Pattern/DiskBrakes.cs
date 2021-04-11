using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class DiskBrakes : IBreaker
    {

        public void Breaking()
        {
            Console.WriteLine("Дисковые тормоза");
        }

  
    }
}
