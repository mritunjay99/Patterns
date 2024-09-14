namespace Design_Patterns.Decorator_Pattern.Base_class
{
    public abstract class CondimentDecorator:Beverage
    {
        //public abstract string getDescription();
        protected Beverage beverage;

        protected CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}
