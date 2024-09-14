using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Design_Pattern
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Pizza() { }

        public abstract void prepare();

        public abstract void bake();

        public abstract void cut();

        public abstract void box();
    }
}
