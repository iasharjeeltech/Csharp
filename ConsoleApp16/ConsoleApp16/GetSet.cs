namespace ConsoleApp16
{

    enum ids
    {
        notfound =404,
        Unauthorized=401,
        internalserver = 500,

    }
    public class GetSet

    {
        public int _id;
        public string _name;
        public int Id
        {
            get{return _id;}
            set{_id = value;}
        }
        public String Name
        {
            get{return _name;}
            set{_name = value;}
        }
        public override string ToString()
        {
            return $"Name: {Name} and Id: {Id}";
        }
    }
}
