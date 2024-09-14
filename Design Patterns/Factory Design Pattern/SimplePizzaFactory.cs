using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Design_Pattern
{
    public class SimplePizzaFactory
    {
        public static Pizza  createPizza(string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza();
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }
    }
}
