namespace Assignment1.Commands;

public class SequentialCommandGroup: CommandGroup
{
    public override void Execute()
    {
        foreach (var command in Commands)
        {
            command.Execute();
        }
    }
}
