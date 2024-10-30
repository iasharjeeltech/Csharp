using System.Numerics;

Console.WriteLine("Enter Your Name:");
string name = Console.ReadLine();

Console.WriteLine("enter you age:");
Byte age = Convert.ToByte(Console.ReadLine());

Console.WriteLine("enter the salary:");
double salary = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("You are a?");
Boolean status = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Enter the Grade:");
char grade = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Write name is:" + name);
Console.WriteLine("Your age is:" + age);
Console.WriteLine("Your grade is:" + grade);
Console.WriteLine("Your salary is:" + salary);
Console.WriteLine("You are a " + status + " person");

Console.WriteLine($"my name is {name} and my age is {age} my salary is {salary} ");

// what is verbatim string

Console.WriteLine()