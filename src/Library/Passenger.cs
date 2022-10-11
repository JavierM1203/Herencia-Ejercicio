using System;
using System.Collections.Generic;
namespace PII_Herencia;

public class Passenger : User
{
    private static List<Passenger> passengerList = new List<Passenger>();

    public Passenger(string name, string lastName, string ID, int rating)
        : base (name, lastName, ID, rating)
        {
            Admin.AddPas(this);
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter($"Bienvenido {this.name}", @$"{this.name}.jpg"));
        }
}