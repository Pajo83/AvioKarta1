using System;
using System.Collections.Generic;
using System.Text;

namespace AvioKarta1
{
    class SingleDestination
    {
        private string town;
        private List<DestinationDate> destinatinDates = new List<DestinationDate>();

        public string Town { get => town; set => town = value; }

        public void AddDestinationDateAndPrice(DateTime dateTime, int price)
        {
            DestinationDate destinatinDate = new DestinationDate();
            destinatinDate.DateTime = dateTime;
            destinatinDate.DestinationPrice = price;
            this.destinatinDates.Add(destinatinDate);
        }

               
        public List<DestinationDate> GetDates()
        {
            return this.destinatinDates;
        }


        public DestinationDate GetDestinationDate(int destinationDateId)
        {
            destinationDateId = destinationDateId - 1;
            return this.destinatinDates[destinationDateId];
        }
    }
}
