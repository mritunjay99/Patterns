namespace Design_Patterns.Command_Pattern.Command
{
    public interface ICommand
    {
        void Execute();
        void undo();
    }
}
