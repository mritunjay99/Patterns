namespace Design_Patterns.Strategy_Design_Pattern
{
    public class FlyWithWings:IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I am flying");
        }
    }
}
