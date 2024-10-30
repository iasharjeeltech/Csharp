

//try
//{
//Console.WriteLine("Enter the value a:");

//var a = int.Parse(Console.ReadLine());

//var isconvirtable = int.TryParse(Console.ReadLine(), out int number);
//    int a = Convert.ToInt16(Console.ReadLine());

//    Console.WriteLine("Enter the value b:");
//    int b = Convert.ToInt16(Console.ReadLine());
//    var Result = a / b;

//} 

//catch (Exception e)
//{

//    Console.WriteLine("Exception details:"+ e.Message);
//}

//finally
//{
//    Console.WriteLine("this block going to executed wheater exception come or not");
//}



//----------------------

//Console.WriteLine("enter the value for a: ");
//var a1 = Convert.ToInt32(Console.ReadLine());

//var a2  = int.Parse(Console.ReadLine());
//var a3 = int.TryParse(Console.ReadLine(), out var num);

//Console.WriteLine(a3.GetType());

//-----------------------------------------

Console.WriteLine("enter the value for a: ");
var a = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("enter the value for b: ");
var b = Convert.ToInt16(Console.ReadLine());

var res = (b==0) ? throw new Exception("Division not allow with Zero") : a/b;


//var result = a / b;
//if (b == 0)
//{
//    throw new Exception("Division not allow with Zero");
//}

Console.WriteLine("result: " + result);