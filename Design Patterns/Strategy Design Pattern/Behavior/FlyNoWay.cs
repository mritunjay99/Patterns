namespace Design_Patterns.Strategy_Design_Pattern
{
    public class FlyNoWay: IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
