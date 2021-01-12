using System;
using System.Collections.Generic;
using System.Text;

namespace AvioKarta1
{
    class Passinger
    {
        private string name;
        
        public Passinger(string name)
        {
            this.name = name;
        }
        public string Name { get => name; set => name = value; }
    }
}
