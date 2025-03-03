namespace SOLID._04_ISP.Good;

public interface ISalaryCalculator
{
    void CalculateSalary();
}

public interface IBenefitCalculator
{
    void CalculateBenefits();
}

public class FullTimeEmployee : ISalaryCalculator, IBenefitCalculator
{
    public void CalculateSalary()
    {
        Console.WriteLine("Contract salary");
    }

    public void CalculateBenefits()
    {
        Console.WriteLine("Contract Benefits");
    }
}

public class ContractEmployee : ISalaryCalculator
{
    public void CalculateSalary()
    {
        Console.WriteLine("Contract salary");
    }
    
}



