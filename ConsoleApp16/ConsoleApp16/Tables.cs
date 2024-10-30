namespace ConsoleApp16
{
    public class Tables
    {
        public void PrintTable()
        {
            Console.WriteLine("Enter the number for Table:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int sum = num * i;
                Console.WriteLine($"{num} x {i} = {sum}");
            }
        }

        //public Tables()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(" ");
        //    }
        //}

        public int TestMethod(int a,int b)
        {
            return  a + b;
        }
    }

    public class Child:Tables
    {
        public Child(){

        }

    }
}