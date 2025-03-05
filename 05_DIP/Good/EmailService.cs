namespace SOLID._05_DIP.Good;

public interface IEmailService
{
    void Send();
}
public class EmailService : IEmailService
{
    public void Send()
    {
        Console.WriteLine("Email sent");
    }
}

public class FakeEmailService : IEmailService
{
    public void Send()
    {
        Console.WriteLine("FAKE EMAIL");
    }
}

public class UserService(IEmailService service)
{
    
}