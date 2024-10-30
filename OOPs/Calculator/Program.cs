using Calculator;

Class1 cal = new Class1();

Console.WriteLine("Enter the First Number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Second Number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

//additon
int Addition = cal.Add(num1,num2);
Console.WriteLine($"If first number {num1} add {num2} is: {Addition}");

//substraction

int Substraction = cal.Subtract(num1, num2);
Console.WriteLine($"if subtract first number {num1} to {num2} is: {Substraction}");

//multiplication

int Multiplication = cal.Multiply(num1, num2);
Console.WriteLine($"the multiplication of first number {num1} to {num2} is: {Multiplication}");

//Division

double Division = cal.Divide(num1, num2);
Console.WriteLine($" Division of first number {num1} to {num2} is: {Division}");

