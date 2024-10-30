namespace Inheritance
{
    public class Person
    {

        public int c { get; set; }
        public int d { get; set; }
        public Person(int a, int b)
        {
            c = a;
            d = b;

            Console.WriteLine($"THis class is Person executed...........!{a*b}");

        }

        public virtual void Walk()
        {
            Console.WriteLine("Person is Walking.............!");
        }

        public virtual void sleep()
        {
            Console.WriteLine("..zzzzzzzzzzz");
        }

        public virtual void eating()
        {
            Console.WriteLine("");
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public Byte Age { get; set; }
         
    }
}