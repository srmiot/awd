using System;

namespace Inheritance Demo

{ class Person

public string Name { get; set; }

public int Age { get; set; }

public void DisplayInfo()

}

{ { } Console.WriteLine($"Name: {Name}, Age: {Age}");

class Employee: Person

{

public int EmployeeID { get; set; }

public string Department { get; set; }

public void Display EmployeeInfo()

{

DisplayInfo();

} Console.WriteLine($"EmployeeID: {EmployeeID), Department: {Department}");

}

internal class Program

{

static void Main(string[] args) { Employee employee = new Employee { Name = "Mrudula Rane", Age=21, EmployeeID = 1234, Department = "IT" }; employee. Display EmployeeInfo(); Console.ReadLine(); }

}

}
