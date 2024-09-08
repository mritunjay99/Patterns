namespace Design_Patterns.Strategy_Design_Pattern
{
    public class Squeak:IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
