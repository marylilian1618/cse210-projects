using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("The apples", "Huancayo", "Junin", "Peru");

        LectureEvent lecture = new LectureEvent("Tech Talk", "A discussion on new technologies", DateTime.Now, new TimeSpan(14, 0, 0), address, "John Doe", 50);

        ReceptionEvent reception = new ReceptionEvent("Networking Event", "An evening of networking and socializing", DateTime.Now, new TimeSpan(18, 0, 0), address, "rsvp@example.com");

        OutdoorEvent gathering = new OutdoorEvent("Summer Picnic", "Enjoy a day outdoors with food and games", DateTime.Now, new TimeSpan(12, 0, 0), address, "Sunny with a chance of clouds");

        Console.WriteLine("Lecture - Standard Details:");
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine("Lecture - Full Details:");
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine("Lecture - Short Description:");
        Console.WriteLine(lecture.ShortDescription());

        Console.WriteLine("\n----------------\n");

        Console.WriteLine("Reception - Standard Details:");
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine("Reception - Full Details:");
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine("Reception - Short Description:");
        Console.WriteLine(reception.ShortDescription());

        Console.WriteLine("\n----------------\n");

        Console.WriteLine("Outdoor Gathering - Standard Details:");
        Console.WriteLine(gathering.StandardDetails());
        Console.WriteLine("Outdoor Gathering - Full Details:");
        Console.WriteLine(gathering.FullDetails());
        Console.WriteLine("Outdoor Gathering - Short Description:");
        Console.WriteLine(gathering.ShortDescription());

    }
}