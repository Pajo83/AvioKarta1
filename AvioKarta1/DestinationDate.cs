using System;
using System.Collections.Generic;
using System.Text;

namespace AvioKarta1
{
    class DestinationDate:Price
    {
        private DateTime dateTime;

        public DateTime DateTime { get => dateTime; set => dateTime = value; }
    }
}
