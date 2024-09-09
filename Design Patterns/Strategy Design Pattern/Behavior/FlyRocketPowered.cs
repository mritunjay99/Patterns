namespace Design_Patterns.Strategy_Design_Pattern.Behavior
{
    public class FlyRocketPowered:IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I am flying with a rocket powered wings");
        }
    }
}
