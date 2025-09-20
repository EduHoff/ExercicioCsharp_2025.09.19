namespace ExercicioCsharp_20250919.Services;

public class AuthService
{
    private EmailService emailService = new EmailService();
    
    public AuthService()
    {
    }

    public string getToken(string username, string password)
    {
        return null;
    }

    public string refreshToken(string token)
    {
        return null;
    }

    public void sendNewPassword(string email)
    {
        
    }
}