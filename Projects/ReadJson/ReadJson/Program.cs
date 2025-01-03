using Newtonsoft.Json;

namespace ReadJson;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        // var fullFilePath = Path.Combine(desktop, "employee.json");
        var filePath = "employee.json";
        var exists = File.Exists(filePath);
        if (exists)
        {
            var json = File.ReadAllText(filePath);
            var employees = JsonConvert.DeserializeObject<Employees>(json);
            var test = employees;
            Console.WriteLine("Serialisation Successful");
            var count = employees.employees.Length;
            Console.WriteLine($"{count} employees found");
            employees.employees.ToList().ForEach(employee =>
            {
                Console.WriteLine($"Name: {employee.firstName} {employee.lastName}");
            });
        }
        else 
            Console.WriteLine("File does not exist");
    }
}