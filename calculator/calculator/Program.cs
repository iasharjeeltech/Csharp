Console.WriteLine("--------Calculator---------");

Console.WriteLine("Enter First Number");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter First Number");
double num2 = Convert.ToDouble(Console.ReadLine());

double addition(double n1, double n2)
{
    double result = n1 + n2;
    //  Console.WriteLine($"This is a result:{result}");
    return result;
}

double myaddition = addition(num1, num2);

Console.WriteLine($"this is a result:{myaddition}");

// int i;  its a diclaration
// i = 1; its a assignment
//int i= 10; its a intialization

