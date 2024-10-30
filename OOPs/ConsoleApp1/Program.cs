

using ConsoleApp1;

Employee emp = new Employee() 
{ 
    Id = 1, 
    FirstName = "sharjeel", 
    LastName = "ansari", 
    Surname = 120000
};

//emp.FirstName = "Sharjeel";
//emp.LastName = "Ansari";
//emp.Salary = 11222;
//emp.Id = 101;

emp.Working();
Console.WriteLine("First Name: "+emp.FirstName);
Console.WriteLine("Last Name: "+emp.LastName);
Console.WriteLine("Salary: "+emp.Salary);
Console.WriteLine("ID: "+emp.Id);