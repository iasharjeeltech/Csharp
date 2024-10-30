namespace ConsoleApp17
{

    public class EnumPerson
    {
        public string PersonName { get; set; }
        public int Age { get; set; }
        public AgeGroupEnum AgeGroup { get; set; }
    }

    public enum AgeGroupEnum{
        Child,
        Adult,
        Senior,
        Teen
    }
}
