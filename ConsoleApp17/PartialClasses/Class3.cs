namespace PartialClasses
{
    public partial class Product
    {
        public double GetTax()
        {
            var tax = ProductCost * 18 / 100;
            return tax;
        }

        public void PrintBill()
        {
            Console.WriteLine($"Product Id: {ProductID}");
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Tax : {GetTax()}");
        }
    }
}
