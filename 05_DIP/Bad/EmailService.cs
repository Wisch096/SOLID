namespace SOLID._05_DIP.Bad;

public class EmailService
{
    public void send()
    {
     
    }   
}

public class UserService(EmailService service)
{
    
}