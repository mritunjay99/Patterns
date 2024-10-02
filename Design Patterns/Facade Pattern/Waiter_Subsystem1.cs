namespace Design_Patterns.Facade_Pattern
{
    public class Waiter_Subsystem1
    {
        public void writeOrder()
        {
            Console.WriteLine("Waiter writes client's order.");
        }

        public void sendToKitchen()
        {
            Console.WriteLine("Send order to kitchen.");
        }

        public void serveCustomer()
        {
            Console.WriteLine("Yeei customer is served!!!");
        }
    }
}
