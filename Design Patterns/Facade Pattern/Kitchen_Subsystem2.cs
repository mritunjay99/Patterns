namespace Design_Patterns.Facade_Pattern
{
    public class Kitchen_Subsystem2
    {
        public void prepareFood()
        {
            Console.WriteLine("Cook food.");
        }

        public void callWaiter()
        {
            Console.WriteLine("Call waiter.");
        }

        public void washDishes()
        {
            Console.WriteLine("Wash the dishes.");
        }
    }
}
