using ConsoleApp16;
using System.Text.Json;
using System.Threading.Channels;
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

void AddEmployeeToFile(List<Employee>employees)
{
    if (true)
    {
        using FileStream stream = new FileStream(s, FileMode.Open, FileAccess.Read);
    }
    using FileStream fileStream = new FileStream(s, FileMode.Open);
    using StreamWriter writer = new StreamWriter(fileStream);
    var EmployeeJson = JsonSerializer.Serialize(employees);
    writer.WriteLine(EmployeeJson);
}




Department department = new Department();

Console.WriteLine("Menu:");
Console.WriteLine("1. Add employee");
Console.WriteLine("2. Get employee by id");
Console.WriteLine("3. Remove employee");
Console.WriteLine("0. Quit");

while (true)
{
    int x = int.Parse(Console.ReadLine());
    if (x == 0)
    {
        break;
    }
    if (x == 1)
    {
        Console.WriteLine("yeni empolyee ucun id:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("yeni empolyee ucun salary:");
        int salary = int.Parse(Console.ReadLine());

        Console.WriteLine("yeni empolyee ucun name:");
        string name = Console.ReadLine();

        Employee employee = new Employee(id, name, salary);
        department.AddEmployee(employee);
    }

}

//1-ci əməliyyatda istifadəçidən employee-nin bütün məlumatları istənəcək yeni bir employee
//obyekti yaranacaq və add methodu vasitəsilə listə əlavə oluncaq daha sonra həmin listi
//json-a serialize edəcəksiniz və həmin serialize olunmuş obyekti database.json faylına əlavə
//edəcəksiniz.

//2-ci əməliyyatda istidaçi bir id daxil edəcək daha sonra database.json faylının oxuyacaqsız
//axıra qədər ordan gələn string-i deserialize edəcəksizin  və GetEmployeeById
//methodu vasitəsilə həmin id-li employee obyektini tapacaqsız

//3-cü əməliyyatda isə yenə 2 ci əməliyyatdakı kimi database.json oxunacaq deserialize olunacaq
//department obyektinə həmin idli employee tapılacaq və listdən silinəcək daha sonra həmin depatment
//yenidən obyekti serialize olunacaq json-a və database.json file-na yazılacaq.