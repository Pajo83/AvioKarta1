using System;
using System.Collections.Generic;
using System.Text;

namespace AvioKarta1
{
    class Destinations
    {
         private List<SingleDestination> singleDestinations  = new List<SingleDestination>();
         
        public void AddDestination(SingleDestination destination)
        {
            this.singleDestinations.Add(destination);

        }

        public void FillDestinations()
        {

            //Barcelona
            SingleDestination destination = new SingleDestination();
            destination.Town = "Barcelona";
            DateTime value = new DateTime(2019, 11, 18, 7, 0, 0);
            int price = 100;
            destination.AddDestinationDateAndPrice(value, price);

            value = new DateTime(2019, 11, 20, 11, 25, 0);
            price = 80;
            destination.AddDestinationDateAndPrice(value, price);

            value = new DateTime(2019, 11, 25, 22, 30, 0);
            price = 30;
            destination.AddDestinationDateAndPrice(value, price);

            this.AddDestination(destination);

            //Bankok
            destination = new SingleDestination();
            destination.Town = "Bankok";
            value = new DateTime(2019, 11, 15, 11, 25, 0);
            price = 200;
            destination.AddDestinationDateAndPrice(value, price);

            value = new DateTime(2019, 11, 11, 7, 0, 0);
            price = 280;
            destination.AddDestinationDateAndPrice(value, price);

            value = new DateTime(2019, 11, 30, 22, 30, 0);
            price = 320;
            destination.AddDestinationDateAndPrice(value, price);

            this.AddDestination(destination);

            //Peking
            destination = new SingleDestination();
            destination.Town = "Peking";
            value = new DateTime(2019, 11, 13, 22, 30, 0);
            price = 150;
            destination.AddDestinationDateAndPrice(value, price);

            value = new DateTime(2019, 11, 21, 11, 25, 0);
            price = 130;
            destination.AddDestinationDateAndPrice(value, price);

            value = new DateTime(2019, 11, 7, 7, 0, 0);
            price = 220;
            destination.AddDestinationDateAndPrice(value, price);

            this.AddDestination(destination);
        }

        public SingleDestination GetDestination(int destinationID)
        {
            destinationID = destinationID - 1;
            return this.singleDestinations[destinationID];
        }
    }
}
