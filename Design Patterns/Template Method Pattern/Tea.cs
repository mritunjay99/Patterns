namespace Design_Patterns.Template_Method_Pattern
{
    public class Tea : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override void brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
