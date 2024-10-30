using Inheritance;

Person p = new Person(10, 10);
p.Walk();
p.Name = "Sharjeel";
p.LastName = "Ansari";
p.Age = 23;
p.DOB = new DateTime(2001,01,04);
Console.WriteLine($"Hey myself {p.Name}{p.LastName} and my age is {p.Age} and DOB is {p.DOB}");

Employee emp = new Employee();
emp.Walk();
emp.Id = 111;
emp.Salary = 20000;
Console.WriteLine($"Hello mySelf {p.Name} and MyEmployee ID is: {emp.Id} and mySalary is {emp.Salary}");

