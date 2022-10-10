namespace PII_Herencia;

class User
{
    string name;
    string lastName;
    string id;
    int rating;

    public User(string name, string lastName, string ID, int rating)
    {
        this.name = name;
        this.lastName = lastName;
        this.id = ID;
        this.rating = rating;
    }
}