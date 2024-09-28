using Design_Patterns.Command_Pattern.Command;

namespace Design_Patterns.Command_Pattern.Invoker
{
    public class RemoteControl
    {
        public ICommand command;
        public Stack<ICommand> commandStack=new Stack<ICommand>();

        public RemoteControl() { }

        public void setCommand(ICommand cmd)
        {
            command = cmd;
            commandStack.Push(cmd);
        }

        public void pressButton()
        {
            command.Execute();
        }

        public void undo()
        {
            if (commandStack.Count() > 0)
            {
                ICommand command = commandStack.Pop();
                command.undo();
            }
            else
            {
                Console.WriteLine("Nothing to undo!");
            }
        }
    }
}
