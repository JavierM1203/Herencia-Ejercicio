namespace PII_Herencia;

class Driver : User
{
    string vehicle;

    public Driver(string name, string lastName, string ID, int rating, string vehicle) 
        : base (name, lastName, ID, rating)    
        {
            this.vehicle = vehicle;
        }

    public void AddPassenger()
    {

    }

    public void RemovePassenger()
    {

    }
}