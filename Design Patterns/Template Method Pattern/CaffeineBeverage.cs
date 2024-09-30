namespace Design_Patterns.Template_Method_Pattern
{
    public abstract class CaffeineBeverage
    {
        public  void PrepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }

        public abstract void brew();

        public abstract void addCondiments();

        public void boilWater()
        {
            Console.WriteLine("Boiling water!");
        }

        public void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
