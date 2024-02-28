using Assignment1.Models.Actuators;

namespace Assignment1.Models.Subsystems;

public class DriveSubsystem
{
    public Motor LeftMotor { get; set; } = new();

    public Motor RightMotor { get; set; } = new();
}
