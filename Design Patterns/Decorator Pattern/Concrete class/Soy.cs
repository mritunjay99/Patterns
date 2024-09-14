using Design_Patterns.Decorator_Pattern.Base_class;

namespace Design_Patterns.Decorator_Pattern.Concrete_class
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage bvg)
        {
            beverage = bvg;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }

        public override double cost()
        {
            return beverage.cost() + 0.30;
        }
    }
}
