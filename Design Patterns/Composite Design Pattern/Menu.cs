namespace Design_Patterns.Composite_Design_Pattern
{
    public class Menu:MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        string name;
        string description;

        public Menu(string name,string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent getChild(int i)
        {
            return menuComponents[i];
        }

        public override string getName()
        {
            return name;
        }

        public override string getDescription()
        {
            return description;
        }

        public override void print()
        {
            Console.WriteLine("\n"+getName()+", "+getDescription());
            Console.WriteLine("-------------");
            IEnumerator<MenuComponent> enumerator = menuComponents.GetEnumerator();
            while (enumerator.MoveNext()) 
            {
                MenuComponent menuComponent = enumerator.Current;
                menuComponent.print();
            }
        }
    }
}
