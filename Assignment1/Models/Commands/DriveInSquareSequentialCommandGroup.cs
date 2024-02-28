namespace Assignment1.Commands;

public class DriveInSquareSequentialCommandGroup:SequentialCommandGroup
{
    public DriveInSquareSequentialCommandGroup()
    {
        AddCommand(new MoveCommand());
        AddCommand(new RotateCommand());

        AddCommand(new MoveCommand());
        AddCommand(new RotateCommand());

        AddCommand(new MoveCommand());
        AddCommand(new RotateCommand());

        AddCommand(new MoveCommand());
        AddCommand(new RotateCommand());
    }
}
