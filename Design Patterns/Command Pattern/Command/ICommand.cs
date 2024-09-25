using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Command_Pattern.Command
{
    public interface ICommand
    {
        void Execute();
        void undo();
    }
}
