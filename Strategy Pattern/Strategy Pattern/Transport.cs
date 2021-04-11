using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{


    public abstract class Transport
    {
        public abstract void UseBrakes(IBreaker breaker);

    }
    public class Car : Transport
    {
        public override void UseBrakes(IBreaker breaker)
        {

            breaker.Breaking();

        }
    }

    public class Motocycle : Transport
    {
        public override void UseBrakes(IBreaker breaker)
        {

            breaker.Breaking();

        }
    }

    public class Skateboard : Transport
    {
        public override void UseBrakes(IBreaker breaker)
        {
            Console.WriteLine("Тормозов нет, но вы держитесь");
        }
    }
}
