namespace Assignment1.Models;

using Assignment1.Models.Subsystems;
public class Robot
{
    public DriveSubsystem Drive { get; set; } = new();

    public TurretSubsystem Turret { get; set; } = new();

    public TargetingSubsystem Target { get; set; } = new();
}
