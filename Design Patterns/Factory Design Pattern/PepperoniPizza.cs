using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Design_Pattern
{
    public class PepperoniPizza:Pizza
    {
        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
        }

        public override void bake()
        {
            Console.WriteLine($"{Name} being baked!");
        }

        public override void box()
        {
            Console.WriteLine($"{Name} being packed in a box!");
        }

        public override void cut()
        {
            Console.WriteLine($"{Name} being cut into equal pieces!");
        }

        public override void prepare()
        {
            Console.WriteLine($"{Name} being prepared!");
        }
    }
}
