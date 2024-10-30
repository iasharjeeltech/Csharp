//using System.Collections;

//int[] intArray = new int[5];

//intArray[0] = 0;
//intArray[1] = 1;
//intArray[2] = 2;
//intArray[3] = 3;
//intArray[4] = 4;
//Console.WriteLine(intArray.Length);
//ArrayList Alist = new ArrayList(3);

//Alist.Add(123);
//Alist.Add("string");
//Alist.Add(true);
//Alist.Add(1.1);
//Alist.Add("A");
//Console.WriteLine(Alist.Capacity);

//List<string> list = new List<string>();

//list.Add("Muhammad");
//list.Add("Sharjeel");
//list.Add("Badruddin");
//list.Add("Ansari");
//Console.WriteLine(list.Count);

//for(int i = 1; i <= 5; i++)
//{
//    for(int j = 1; j <= i-1; j++)
//    {
//        Console.Write(" ");
//    }
//    for(int k = 1; k <=(2*i-1); k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine(); 

//}

//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <=i; j++)
//    {
//        Console.Write(i);
//    }
//    Console.WriteLine(i);
//}

//int rows = 5;

//for (int i =1; i <=rows ; i++)
//{
//    for(int j = 1; j <=rows-i; j++)
//    {
//        Console.Write("-");
//    }
//    for(int k = 1;  k <=i; k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

using System.Diagnostics;
using System.Text;

StringBuilder sb = new StringBuilder("Sharjeel");
string s = sb.ToString();
Stopwatch sw = Stopwatch.StartNew();
sw.Start();
for(int i =0; i < 100000; i++)
{
    sb.Append(i);
}
sw.Stop();
Console.WriteLine("String Builder: "+sw.ElapsedMilliseconds);
Console.WriteLine("---------------------------------------");

string str = "Sharjeel";
Stopwatch sw2 = Stopwatch.StartNew();
sw2.Start();
for(int i =0;i < 100000; i++)
{
    str = str + i;
}
sw2.Stop();
Console.WriteLine("String: "+sw2.ElapsedMilliseconds);