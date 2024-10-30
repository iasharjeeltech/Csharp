namespace Calculator
{
    public class Class1
    {
        public int Add(int a,int b){
            return a + b;
        }
        public int Subtract(int a,int b){
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public Double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Can not divide by Zero..!");
                return 0;
            }
            return a/b;
        }
    }
}
