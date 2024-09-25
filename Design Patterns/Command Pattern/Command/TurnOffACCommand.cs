using Design_Patterns.Command_Pattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Command_Pattern.Command
{
    public class TurnOffACCommand : ICommand
    {
        AcController Controller;

        public TurnOffACCommand(AcController ac)
        {
            Controller = ac;
        }

        public void Execute()
        {
            Controller.turnOffAC();
        }

        public void undo()
        {
            Controller.turnOnAC();
        }
    }
}
