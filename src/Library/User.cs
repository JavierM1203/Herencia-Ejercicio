namespace PII_Herencia;

public abstract class User
{
    public string name {get; private set;}
    public string lastName {get; private set;}
    public string id {get; private set;}
    public int rating {get; private set;}

    public User(string name, string lastName, string ID, int rating)
    {
        this.name = name;
        this.lastName = lastName;
        this.id = ID;
        this.rating = rating;
    }
}