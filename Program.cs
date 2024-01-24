using ConsoleApp17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aumenta il volume");
            double Volume = Convert.ToDouble(Console.ReadLine());
            Radio radio = new Radio(Volume);
            Console.WriteLine("{0}", radio.AumentaVolume());
            Console.WriteLine("Diminuisci il volume");
            Console.WriteLine("{0}", radio.DiminuisciVolume());
        }
    }
}