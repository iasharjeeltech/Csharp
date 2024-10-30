Car Verna = new Car();

Verna.Name = "hyundai verna";
Verna.Price = 200000;

Console.WriteLine("verna object name:"+Verna.Name);
Console.WriteLine("verna object price:"+Verna.Price);

Car thar = new Car();

thar.Name = "thar mahindra";
thar.Price = 1200000;

Console.WriteLine("verna object name:" + thar.Name);
Console.WriteLine("verna object price:" + thar.Price);

Verna.Drive();
thar.Drive();