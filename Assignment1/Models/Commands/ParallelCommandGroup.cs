namespace Assignment1.Commands;

public class ParallelCommandGroup:CommandGroup
{
    public override void Execute()
    {
        Parallel.ForEach(Commands, command =>
        {
            command.Execute();
        });
    }
}
