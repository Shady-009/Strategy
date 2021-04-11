using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main()
        {
            var car = new Car();
            car.UseBrakes(new DiskBrakes());
            car.UseBrakes(new HandBrake());
            var motocycle = new Motocycle();
            motocycle.UseBrakes(new DiskBrakes());
            var skateboard = new Skateboard();
            skateboard.UseBrakes(new DiskBrakes());
            Console.ReadKey();
        }
    }
}
