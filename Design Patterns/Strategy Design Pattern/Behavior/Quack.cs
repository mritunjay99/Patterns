namespace Design_Patterns.Strategy_Design_Pattern
{
    public class Quack:IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("quack");
        }
    }
}
