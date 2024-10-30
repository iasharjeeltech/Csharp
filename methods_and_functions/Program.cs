//  methods and function 

void  TestMethod(string name="sharjeel", byte age=23)
{
    Console.WriteLine($"Your {name} is and your age is {age}");
}

TestMethod("sharjeel");
TestMethod(age: 23, name: "sharjeel");
//this is a parameters and direct calling

