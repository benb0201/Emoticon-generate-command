public class Invoker // User class
{
    private Stack<ICommand> history; // history stack of commands
    private Stack<ICommand> redo; // redo stack of commands
    public Invoker()
    {
        //resets stacks
        history = new Stack<ICommand>();
        redo = new Stack<ICommand>();
    }

    public void AddCommand(ICommand command) //Adds command to history stack
    {
        history.Push(command);
        command.Execute();
    }

    public void Undo() //Undoes a command and stores in redo stack
    {
        if (history.Count <= 0)
        {
            return;
        }

        var cmd = history.Pop();
        cmd.UnExecute();
        redo.Push(cmd);
    }

    public void Redo() //Redoes command and stores in history stack
    {
        if (redo.Count <= 0)
        {
            return;
        }

        var cmd = redo.Pop();
        cmd.Execute();
        history.Push(cmd);
    }
}