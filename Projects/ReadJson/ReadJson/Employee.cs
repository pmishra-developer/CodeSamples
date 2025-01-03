namespace ReadJson;

/*
public class Employees
{
    public Employee[] employees { get; set; }
}

public class Employee
{
    public string firstName { get; set; }
    public string lastName { get; set; }
}
*/




public class TableData
{
    public TableInformation[] tableInformation { get; set; }
}

public class TableInformation
{
    public string INTERFACE_NAME { get; set; }
    public string FREQUENCY_OF_RUN { get; set; }
    public string LOCATION_TYPE_NAME { get; set; }
    public string UNITS_CODE { get; set; }
    public string COST_CODE { get; set; }
    public string RETAIL_CODE { get; set; }
    public string COST_REFERENCE_TABLE { get; set; }
    public string RETAIL_REFERENCE_TABLE { get; set; }
    public string LANDING_TABLE_NAME { get; set; }
    public string STAGING_TABLE_NAME { get; set; }
    public string DESTINATION_TABLE_NAME { get; set; }
    public string UNITS_CODE_FULL_PRICE { get; set; }
    public string COST_CODE_FULL_PRICE { get; set; }
    public string RETAIL_CODE_FULL_PRICE { get; set; }
}

