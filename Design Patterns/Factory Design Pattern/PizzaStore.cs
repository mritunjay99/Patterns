using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Design_Pattern
{
    public class PizzaStore
    {
        public Pizza orderPizza(string type)
        {
            Pizza pizza;

            pizza=SimplePizzaFactory.createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
