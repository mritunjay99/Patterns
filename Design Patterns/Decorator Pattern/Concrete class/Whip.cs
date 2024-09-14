using Design_Patterns.Decorator_Pattern.Base_class;

namespace Design_Patterns.Decorator_Pattern.Concrete_class
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage bvg) : base(bvg) { }
        
        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }

        public override double cost()
        {
            return beverage.cost() + 0.40;
        }
    }
}
