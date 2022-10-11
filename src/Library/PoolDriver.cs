using System.Collections.Generic;  

namespace PII_Herencia;

public class PoolDriver : Driver
{
    public int capacity {get; private set;}
    List<Passenger> passengers = new List<Passenger>();

    public PoolDriver(string name, string lastName, string ID, int rating, string vehicle, string bio, int capacity)
        : base (name, lastName, ID, rating, vehicle, bio)
        {
            this.capacity = capacity;
        }

    public void AddPassenger(Passenger passenger)
    {
        int passengersLength = this.passengers.Count;

        if (passengersLength < capacity)
        {
            passengers.Add(passenger);
        } else {
            System.Console.WriteLine("The vehicle is already full");
        }
    }

    public void RemovePassenger(Passenger passenger)
    {
        if (this.passengers.Contains(passenger))
        {
            this.passengers.Remove(passenger);
        } else {
            System.Console.WriteLine("Passenger is not in the list");
        }
    }

}