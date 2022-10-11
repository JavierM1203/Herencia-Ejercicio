namespace PII_Herencia;

public class Driver : User
{
    public string vehicle {get; private set;}

    public Driver(string name, string lastName, string ID, int rating, string vehicle) 
        : base (name, lastName, ID, rating)    
        {
            this.vehicle = vehicle;
            Admin.AddDriver(this);
        }

    public void AddPassenger()
    {

    }

    public void RemovePassenger()
    {

    }
}