using Design_Patterns.Command_Pattern.Receiver;

namespace Design_Patterns.Command_Pattern.Command
{
    public class TurnOnACCommand : ICommand
    {
        AcController Controller;

        public TurnOnACCommand(AcController ac)
        {
            Controller = ac;
        }

        public void Execute()
        {
            Controller.turnOnAC();
        }
        
        public void undo()
        {
            Controller.turnOffAC();
        }
    }
}
