namespace Design_Patterns.Facade_Pattern
{
    public class Order_Facade
    {
        private Waiter_Subsystem1 waiter = new Waiter_Subsystem1();
        private Kitchen_Subsystem2 kitchen = new Kitchen_Subsystem2();

        public void orderFood()
        {
            Console.WriteLine("A series of interdependent calls on various subsystems:");
            waiter.writeOrder();
            waiter.sendToKitchen();
            kitchen.prepareFood();
            kitchen.callWaiter();
            waiter.serveCustomer();
            kitchen.washDishes();
        }
    }
}
