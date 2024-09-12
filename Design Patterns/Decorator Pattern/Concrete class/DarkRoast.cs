using Design_Patterns.Decorator_Pattern.Base_class;

namespace Design_Patterns.Decorator_Pattern.Concrete_class
{
    public class DarkRoast:Beverage
    {
        //public DarkRoast()
        //{
        //    description = "Beverage coffee";
        //}
        public override string getDescription()
        {
            return "Beverage coffee";
        }
        public override double cost()
        {
            return 0.50;
        }
    }
}
