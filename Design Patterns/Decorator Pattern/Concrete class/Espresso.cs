using Design_Patterns.Decorator_Pattern.Base_class;

namespace Design_Patterns.Decorator_Pattern.Concrete_class
{
    public class Espresso:Beverage
    {
        public override string getDescription()
        {
            return "Espresso";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
