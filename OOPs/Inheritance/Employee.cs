namespace Inheritance
{
    public class Employee : Person
    {
        public Employee() : base(10, 5)
        {
            Console.WriteLine($"THis class is Employee executed...........!  a + b = {c+d}");
        }
        public new void Walk()
        {
            Console.WriteLine("Employee is Walking.............!");
        }

        public override void sleep()
        {
            base.sleep();
        }

        public override void eating()
        {
            base.eating();
        }
        public int Id { get; set; }
        public double Salary { get; set; }

    }
}
