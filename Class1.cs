using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Radio
    {
        public double Volume { get; set; }
        public Radio(double Volume)
        {
            this.Volume = Volume;
        }
        public double AumentaVolume()
        {
            return Volume + 0.10;
        }
        public double DiminuisciVolume()
        {
            return Volume - 0.10;
        }
    }
}
