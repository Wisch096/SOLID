namespace SOLID._04_ISP.Bad;

public interface Employee
{
    string Name { get; set; }
    void CalculateSalary();
    void CalculateBenefits();
}

public class FullTimeEmployee : Employee
{
    public string Name { get; set; }
    
    public void CalculateSalary()
    {
        Console.WriteLine("Contract salary");
    }

    public void CalculateBenefits()
    {
        Console.WriteLine("Contract benefits");
    }
}

public class ContractEmployee : Employee
{
    public string Name { get; set; }
    
    public void CalculateSalary()
    {
        Console.WriteLine("Contract salary");
    }

    public void CalculateBenefits()
    {
        throw new NotImplementedException();
    }
}