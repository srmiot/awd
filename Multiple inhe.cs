using System;

namespace Inheritance Demo

{

interface ICanMove

{

void Move();

}

interface ICanSpeak

{

void Speak();

}

class Robot: ICanMove, ICanSpeak

{

public void Move()

{ } Console.WriteLine("Robot is moving.");

public void Speak()

{ } Console.WriteLine("Robot is speaking.");

}

internal class Program

{

static void Main(string[] args)

{

Robot robot = new Robot();

robot.Move();

robot.Speak();

Console.ReadLine();

}

}

}
