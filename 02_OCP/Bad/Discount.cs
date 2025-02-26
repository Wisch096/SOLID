namespace SOLID._02_OCP.Bad;

public enum EProductType
{
    Electronics = 1,
    Health = 2,
    Beauty = 3,
    Fashion = 4,
}

public class Discount
{
    public decimal Calculate(EProductType type, decimal price)
    {
        if (type == EProductType.Electronics)
            return price * 0.2M;
        
        if(type == EProductType.Health)
            return price * 0.3M;

        if (type == EProductType.Fashion)
            return price * 0.4M;
        
        if(type == EProductType.Beauty)
            return price * 0.5M;

        return price;
    }
}