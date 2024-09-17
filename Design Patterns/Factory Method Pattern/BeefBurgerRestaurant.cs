using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Method_Pattern
{
    public class BeefBurgerRestaurant : Restaurant
    {
        public override Burger createBurger()
        {
            return new BeefBurger();
        }
    }
}
