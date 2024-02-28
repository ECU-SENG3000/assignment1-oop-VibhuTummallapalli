namespace Assignment1.Commands;

public class RotateCommand: Command
{
    public override void Setup()
    {
        Console.WriteLine("MoveCommand.Setup");
    }

    public override void Execute()
    {
        Console.WriteLine("Moving...");
    }

    public override void End()
    {
        Console.WriteLine("MoveCommand.End");
    }
}
