namespace Design_Patterns.Strategy_Design_Pattern
{
    public abstract class Duck
    {
        public IFlyBehavior? flyBehavior = null;
        public IQuackBehavior? quackBehavior = null;

        public Duck() { }

        public abstract void display();

        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
        public void performFly()
        {
            flyBehavior?.fly();
        }

        public void performQuack()
        {
            quackBehavior?.quack();
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }
    }
}
