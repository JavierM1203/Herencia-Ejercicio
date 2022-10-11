namespace PII_Herencia;
using System.Collections.Generic;

public class Passenger : User
{
    private static List<Passenger> passengerList = new List<Passenger>();

    public Passenger(string name, string lastName, string ID, int rating)
        : base (name, lastName, ID, rating)
        {
            Admin.AddPas(this);
        }
}