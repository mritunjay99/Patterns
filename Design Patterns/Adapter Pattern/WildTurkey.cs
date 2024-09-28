namespace Design_Patterns.Adapter_Pattern
{
    public class WildTurkey:ITurkey
    {
        public void gobble()
        {
            Console.WriteLine("Gobble Gobble!");
        }

        public void fly()
        {
            Console.WriteLine("Flying short distance!");
        }
    }
}
