using Assignment1.Commands;

namespace Assignment1;

public class CommandGroup
{
    public List<Command> Commands { get; set; } = new();

    public virtual void Execute()
    {
        
    }

    public void AddCommand(Command command)
    {
        Commands.Add(command);
    }
}
