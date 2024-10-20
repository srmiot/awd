using System; namespace Pradt1._3

{ struct Stud

{

int stud id; string stud_name; string stud_course; DateTime stud dob; public void Input()

{ Console.WriteLine("Enter Student ID: "); stud_id= Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Enter Student Name: "); stud_name Console.ReadLine(); Console.WriteLine("Enter Student Course: "); Console.WriteLine("Enter Student DOB(DD-MM-YYYY): ");

stud_course = Console.ReadLine();

stud_dob DateTime.Parse(Console.ReadLine());

} public void Show()

Console.WriteLine("\n");

Console.WriteLine("Student Information:");

Console.WriteLine("ID: " + stud_id); Console.WriteLine("Name: " + stud_name); Console.WriteLine("Course: " + stud course); Console.WriteLine("Date of Birth: " + stud_dob.ToShortDateString());

} class SD

{ static void Main()

{

Stud[] s new Stud[3]; for(int i=0;i<s.Length;i++)

Console.WriteLine($"Enter Student Details (i+1)}: ");

s[i].Input();

} for (int i=0;i<s.Length;i++)

s[i].Show();

}
}
}
}
