using System.Collections.Generic;

namespace PII_Herencia;

public class Admin
{
    public static List<Passenger> passengers = new List<Passenger>() { };

    public static List<Driver> drivers = new List<Driver>() { };

    
    public static void AddPas(Passenger pas)
    {
        passengers.Add(pas);
    }

    public static void AddDriver(Driver driver)
    {
        drivers.Add(driver);
    }
}