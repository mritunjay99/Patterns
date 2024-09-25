using Design_Patterns.Command_Pattern.Command;

namespace Design_Patterns.Command_Pattern.Invoker
{
    public class RemoteControl
    {
        public ICommand command;

        public RemoteControl() { }

        public void setCommand(ICommand cmd)
        {
            command = cmd;
        }

        public void pressButton()
        {
            command.Execute();
        }
    }
}
