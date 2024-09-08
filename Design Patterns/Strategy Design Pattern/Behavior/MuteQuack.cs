namespace Design_Patterns.Strategy_Design_Pattern
{
    public class MuteQuack: IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<Silence>");
        }
    }
}
