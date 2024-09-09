namespace Design_Patterns.Strategy_Design_Pattern
{
    public class MallardDuck:Duck
    {
        public MallardDuck() 
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I am a real Mallard duck");
        }
    }
}
