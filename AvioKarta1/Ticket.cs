using System;
using System.Collections.Generic;
using System.Text;

namespace AvioKarta1
{
    class Ticket
    {
        private Passinger passinger;
        private string destination;
        private DateTime dateTime;
        private int price;

        public Ticket(Passinger passinger, string destination, DateTime dateTime, int price)
        {
            this.passinger = passinger;
            this.destination = destination;
            this.dateTime = dateTime;
            this.price = price;
        }
        
        public string GetTicketInfo()
        {
            return $"{passinger.Name} is traveling to {destination} at {dateTime} for ${price} ";
           
        }
    }
}
