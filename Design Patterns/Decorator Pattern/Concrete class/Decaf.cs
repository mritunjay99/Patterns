using Design_Patterns.Decorator_Pattern.Base_class;

namespace Design_Patterns.Decorator_Pattern.Concrete_class
{
    public class Decaf:Beverage
    {
        //public Decaf()
        //{
        //    description = "Decaf coffee";
        //}

        public override string getDescription()
        {
            return "Decaf coffee";
        }
        public override double cost()
        {
            return 1.00;
        }
    }
}
