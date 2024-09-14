using Design_Patterns.Decorator_Pattern.Base_class;

namespace Design_Patterns.Decorator_Pattern.Concrete_class
{
    public class Mocha:CondimentDecorator
    {
        public Mocha(Beverage bvg) : base(bvg) { }
        

        public override string getDescription()
        {
            return beverage.getDescription()+",Mocha";
        }

        public override double cost()
        {
            return 0.20+beverage.cost();
        }
    }
}
