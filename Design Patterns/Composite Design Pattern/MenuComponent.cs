namespace Design_Patterns.Composite_Design_Pattern
{
    public abstract class MenuComponent
    {
        public virtual void add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent getChild(int i)
        {
            throw new NotSupportedException();
        }

        public virtual string getName()
        {
            throw new NotSupportedException();
        }

        public virtual string getDescription()
        {
            throw new NotSupportedException();
        }

        public virtual double getPrice()
        {
            throw new NotSupportedException();
        }

        public virtual bool isVegetarian()
        {
            throw new NotSupportedException();
        }

        public virtual void print()
        {
            throw new NotSupportedException();
        }
    }
}
