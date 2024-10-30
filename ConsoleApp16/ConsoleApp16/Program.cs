//Console.WriteLine("Enter the number for Table:");
//int num = Convert.ToInt32(Console.ReadLine());

//for(int i =1; i <=10; i++)
//{
//    int sum = num * i;
//    Console.WriteLine($"{num} x {i} = {sum}");
//}

//using ConsoleApp16;

//Child c = new Child();

//c.PrintTable();

using ConsoleApp16;

GetSet gs = new GetSet();
gs.Name = "sharjeel";
gs.Id = 1;

Console.WriteLine(gs.Name);

var a = gs.ToString();
Console.WriteLine(a);