using System;

namespace InheritanceDemo

class Person

{

public string Name { get; set; } public int Age { get; set; }

public void DisplayInfo()

{ } Console.WriteLine($"Name: (Name), Age: {Age}");

}

class Employee: Person

{

public int EmployeeID { get; set; }

public string Department { get; set; }

public void Display EmployeeInfo()

{

Display Info();

Console.WriteLine($"EmployeeID: (EmployeelD), Department: (Department}");

}

class Manager: Employee

{

public int NumberOfTeams { get; set; }

public void DisplayManagerInfo()

{

Display EmployeeInfo();

Console.WriteLine($"Number of Teams: (NumberOfTeams)");

}

}

internal class Program {

static void Main(string[] args)

{

Manager manager = new Manager

{

Name "Tony stark",

Age 43, EmployeeID=5678,

Department = "IT", NumberOfTeams = 5 1:

manager. Display ManagerInfo();

Console.ReadLine();

}}}
