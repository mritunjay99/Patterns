using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy_Design_Pattern
{
    public class Quack:IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("quack");
        }
    }
}
