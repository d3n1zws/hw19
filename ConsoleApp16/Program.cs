using System.Xml.Linq;

string s = "C:\\Users\\LocUser\\OneDrive\\ConsoleApp16\\ConsoleApp16\\Files\\DataBase.jhon";
if (Directory.Exists(s))
{
    Console.WriteLine("Directory exists");
}
else
{
    Directory.CreateDirectory(s);
    Console.WriteLine("Directory created");
}