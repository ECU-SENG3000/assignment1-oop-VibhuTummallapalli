// See https://aka.ms/new-console-template for more information

using Assignment1.Commands;
using Assignment1.Models;

Console.WriteLine("Hello, World!");

Robot robot = new();

robot.Drive.LeftMotor.Move(0.5f);

robot.Drive.RightMotor.Move(0.5f);

float distance = robot.Drive.LeftMotor.Encoder.GetDistance();
Console.WriteLine($"Distance: {distance} feet.");   

MoveCommand.StaticProperty = 1;

MoveCommand moveCommand = new();
Console.WriteLine(MoveCommand.StaticProperty);
MoveCommand moveCommand2 = new();
Console.WriteLine(MoveCommand.StaticProperty);
MoveCommand moveCommand3 = new();
Console.WriteLine(MoveCommand.StaticProperty);

moveCommand.WriteStaticProperty();
moveCommand2.WriteStaticProperty();
moveCommand3.WriteStaticProperty();

moveCommand.InstanceProperty = 1;

SequentialCommandGroup sequentialProgram = new();



DriveInSquareSequentialCommandGroup driveInSquare = new();
driveInSquare.Execute();