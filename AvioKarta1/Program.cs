using System;
using System.Collections.Generic;

namespace AvioKarta1
{
    class Program
    {
        static void Main(string[] args)
        {
            Destinations destinations = new Destinations();
            destinations.FillDestinations();

            Console.WriteLine($"Pleace select ypur destination.");
            Console.WriteLine($"1: Barcelona ");
            Console.WriteLine($"2: Bankok");
            Console.WriteLine($"3: Peking");

            int destId = int.Parse(Console.ReadLine());

            while(destId < 1 || destId > 3)
            {
                Console.WriteLine($"You entered invalid destination, please try again");
                destId = int.Parse(Console.ReadLine());
            }

            var destination = destinations.GetDestination(destId);
            var town = destination.Town;

            var destionationDates = destination.GetDates();
            for (int i = 0; i < destionationDates.Count; i++)
            {
                Console.WriteLine($"{i+1}: {destionationDates[i].DateTime} Price: {destionationDates[i].DestinationPrice}");
            }

            int destDateID = int.Parse(Console.ReadLine());
            while (destDateID < 1 || destDateID  > 3)
            {
                Console.WriteLine($"You entered invalid destination date, please try again");
                destDateID = int.Parse(Console.ReadLine());
            }

            var singleDatePrice = destination.GetDestinationDate(destDateID);

            Console.WriteLine($"Enter passenger name: ");
            string name = Console.ReadLine();

            Passinger passinger = new Passinger(name);


            Ticket ticket = new Ticket(passinger, town, singleDatePrice.DateTime, singleDatePrice.DestinationPrice);

            Console.WriteLine($"{ticket.GetTicketInfo()}");
        }
    }
}
