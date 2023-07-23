
using System;

namespace Foundation3
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("1066", "Watt Street", "Okahandja", "Otjozondjupa", "Namibia");
            Address address2 = new Address("456", "Bruhn Street", "Windhoek", "Khomas", "Namibia");
            Address address3 = new Address("789", "Mercie Street", "Ondangwa", "Omusati", "Namibia");

            Lecture lecture = new Lecture("Lukas Nakale", 50, "Effective Public Speaking", "Learn the art of public speaking.", DateTime.Now, TimeSpan.FromMinutes(120), address1);

            Reception reception = new Reception("rsvp@example.com", "Networking Event", "Join us for a networking event.", DateTime.Now.AddDays(7), TimeSpan.FromMinutes(180), address2);

            OutdoorGathering outdoorGathering = new OutdoorGathering("Sunny", "Picnic in the Park", "Enjoy a day of fun and food in the park.", DateTime.Now.AddDays(14), TimeSpan.FromMinutes(240), address3);

            Event[] events = { lecture, reception, outdoorGathering };

            foreach (Event e in events)
            {
                Console.WriteLine("Standard Details:");
                e.DisplayStandDetails();
                Console.WriteLine();

                Console.WriteLine("Full Details:");
                e.DisplayFullDetails();
                Console.WriteLine();

                Console.WriteLine("Short Description:");
                e.DisplayShortDescription();
                Console.WriteLine();
            }
        }
    }
}

