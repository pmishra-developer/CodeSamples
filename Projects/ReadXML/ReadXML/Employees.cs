using System.Xml.Serialization;

namespace ReadXML;

[XmlRoot(ElementName="employee")]
public class Employee { 

    [XmlElement(ElementName="firstName")] 
    public string FirstName { get; set; } 

    [XmlElement(ElementName="lastName")] 
    public string LastName { get; set; } 
}

[XmlRoot(ElementName="employees")]
public class Employees { 

    [XmlElement(ElementName="employee")] 
    public List<Employee> Employee { get; set; } 
}



