using Design_Patterns.Command_Pattern.Receiver;

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
