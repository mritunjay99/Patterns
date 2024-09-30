namespace Design_Patterns.Template_Method_Pattern
{
    public class Coffee : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
    }
}
