using System;

namespace PII_Herencia;

public class Driver : User
{
    public string vehicle {get; private set;}
    public string bio {get; private set;}


    public Driver(string name, string lastName, string ID, int rating, string vehicle, string bio) 
        : base (name, lastName, ID, rating)    
        {
            this.vehicle = vehicle;
            this.bio = bio;
            Admin.AddDriver(this);
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter($"Bienvenido {this.name}", @$"{this.name}.jpg"));
        }

    public void AddPassenger()
    {

    }

    public void RemovePassenger()
    {

    }
}