using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Method_Pattern
{
    public abstract class Restaurant
    {
        public Burger orderBurger()
        {
            Burger burger = createBurger();
            burger.prepare();
            return burger;
        }

        public abstract Burger createBurger();
    }
}
