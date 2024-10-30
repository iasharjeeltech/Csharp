namespace Practice
{
    public class Messagess
    {
        public string Name {  get; set; }
        public string LastName { get; set; }
        public long MobNo {  get; set; }

        public void Hello()
        {
            Console.WriteLine("Hello mySelf :");
        }
        public void Waiting()
        {
            Console.WriteLine("i am waiting for someone call me by my method!");
        }
        public void By()
        {
            Console.WriteLine("Bye buddy!! see you in next program!");
        }
    }
}
