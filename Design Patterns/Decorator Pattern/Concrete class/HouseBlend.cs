using Design_Patterns.Decorator_Pattern.Base_class;

namespace Design_Patterns.Decorator_Pattern.Concrete_class
{
    public  class HouseBlend:Beverage
    {
        //public HouseBlend() 
        //{
        //    description = "House Blend COffee";
        //}
        public override string getDescription()
        {
            return "House Blend Coffee";
        }
        public override double cost()
        {
            return 0.89;
        }
    }
}
