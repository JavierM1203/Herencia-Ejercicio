namespace PII_Herencia;

public class CommonDriver : Driver
{      
    public Passenger passenger {get; set;}
    public CommonDriver(string name, string lastName, string ID, int rating, string vehicle, string bio, Passenger passenger) 
        : base (name, lastName, ID, rating, vehicle, bio)    
        {
            this.passenger = passenger;
        }

    public void AddPassenger(Passenger passenger)
    {
        if (this.passenger != null)
        {
            this.passenger = passenger;
        } else {
            System.Console.WriteLine("There is already a passenger");
        }
    }
    
    public void RemovePassenger()
    {
        this.passenger = null;
    }
}