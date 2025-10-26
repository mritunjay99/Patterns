using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Pattern
{
    public  interface State
    {
        public void insertQuarter();

        public void ejectQuarter();

        public void turnCrank();

        public void dispense();
    }
}
