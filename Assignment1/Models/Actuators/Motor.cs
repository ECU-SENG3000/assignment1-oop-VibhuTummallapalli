using Assignment1.Models.Sensors;

namespace Assignment1.Models.Actuators;

public class Motor
{
    public Encoder Encoder { get; set; } = new();
    public void Move(float speed)
    {
        Console.WriteLine($"Motor is moving at {speed} speed");
    }
}
