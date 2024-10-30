


string path = @"D:\DotNet\ConsoleApp17\SystemFileHandling\Sharjeel.txt";


//File.Create(path);
//Console.WriteLine("The File has been Created!!!");


//File.WriteAllText(path,"Hello form my code...!");
//Console.WriteLine("Code printed in text file!");


//string content = File.ReadAllText(path);
//Console.WriteLine($"path file store this lines>> : {content}"); 

//var contents = new string[] {
//    "qwertyuiop",
//    "asdfghjkl",
//    "zxcvbnm"
//};

//File.WriteAllLines(path, contents);

string[] contentsFromFile = File.ReadAllLines(path);
foreach (string content in contentsFromFile)
{
    Console.WriteLine(content);
}
//Console.WriteLine(contentsF.
//romFile);21