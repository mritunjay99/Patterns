namespace Design_Patterns.Strategy_Design_Pattern.DuckCLass
{
    public class ModelDuck:Duck
    {
        public ModelDuck() 
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I am a model duck");
        }
    }
}
