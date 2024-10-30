namespace ConsoleApp13
{
    public static class ExtensionMethods
    {
        //public static void Study(this Student Student, int a, int b) //yaha sirf mujhe parameter check karna thah isliye diya hoon
        //{
        //    Console.WriteLine("Enter the value of a: ");
        //    a = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the value of b:");
        //    b = Convert.ToInt32(Console.ReadLine());
        //    int multiply = a * b;
        //    Console.WriteLine($"THis is extension class from Study and this is the multiplication if a nd b:{multiply}");
        //}

        public static void MyStringMethod(this String MyString)
        {
            Console.WriteLine("yeh string call hogi for string methods ke liye!");
        }
    }
}