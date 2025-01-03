using Newtonsoft.Json;

namespace ReadJson;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        var fullFilePath = Path.Combine(desktop, "mfp_interface.json");
        bool exists = File.Exists(fullFilePath);
        if (exists)
        {
            var json = File.ReadAllText(fullFilePath);
            var mfpInterface = JsonConvert.DeserializeObject<TableData>(json);
            if (mfpInterface == null)
            {
                Console.WriteLine("Deserialization failed");
                return;
            }
            
            Console.WriteLine("Deserialization successful");
            
            Console.WriteLine("Landing Tables");
            Console.WriteLine("-----------------");
            var landingTableNames = mfpInterface.tableInformation.Select(x => x.LANDING_TABLE_NAME);
            foreach (var landingTableName in landingTableNames)
            {
                if(!string.IsNullOrEmpty(landingTableName))
                    Console.WriteLine(landingTableName);
            }
            
            Console.WriteLine("                ");
            Console.WriteLine("Staging Tables");
            Console.WriteLine("-----------------");
            var stagingTableNames = mfpInterface.tableInformation.Select(x => x.STAGING_TABLE_NAME);
            foreach (var stagingTableName in stagingTableNames)
            {
                if (!string.IsNullOrEmpty(stagingTableName))
                    Console.WriteLine(stagingTableName);
            }

            Console.WriteLine("                ");
            Console.WriteLine("Destination Tables");
            Console.WriteLine("-----------------");
            var destinationTableNames = mfpInterface.tableInformation.Select(x => x.DESTINATION_TABLE_NAME);
            foreach (var destinationTableName in destinationTableNames)
            {
                if (!string.IsNullOrEmpty(destinationTableName))
                    Console.WriteLine(destinationTableName);
            }
        }
        else 
            Console.WriteLine("File does not exist");
    }
}