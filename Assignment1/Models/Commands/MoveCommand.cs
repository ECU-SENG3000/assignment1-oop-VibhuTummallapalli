namespace Assignment1.Commands;

public class MoveCommand: Command
{
    public static int StaticProperty { get; set; }

    public int InstanceProperty { get; set; }

    public MoveCommand()
    {
        StaticProperty++;
    }

    public void WriteStaticProperty()
    {
        Console.WriteLine($"StaticProperty: {StaticProperty}");
    }

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
