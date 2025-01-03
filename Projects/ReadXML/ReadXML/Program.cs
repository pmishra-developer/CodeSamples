using System.Xml;
using System.Xml.Serialization;

namespace ReadXML;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        // var fullFilePath = Path.Combine(desktop, "employee.json");
        var filePath = "employee.xml";
        var exists = File.Exists(filePath);
        if (exists)
        {
            var json = File.ReadAllText(filePath);
            var serializer = new XmlSerializer(typeof(Employees));
            var employees = (Employees)serializer.Deserialize(new StringReader(json))!;
            
            var test = employees;
            Console.WriteLine("Serialisation Successful");
            var count = employees.Employee.Count;
            Console.WriteLine($"{count} employees found");
            employees.Employee.ToList().ForEach(employee =>
            {
                Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}");
            });
        }
        else 
            Console.WriteLine("File does not exist");
    }
}