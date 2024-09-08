using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy_Design_Pattern
{
    public class FlyWithWings:IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I am flying");
        }
    }
}
