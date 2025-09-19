namespace ExercicioCsharp_20250919.Entities;

public class Client
{
    public string name { get; set; }
    public string email { get; set; }
    public DateTime birthDate { get; set; }

    public Client()
    {
    }

    public Client(string name, string email, DateTime birthDate)
    {
        this.name = name;
        this.email = email;
        this.birthDate = birthDate;
    }
}