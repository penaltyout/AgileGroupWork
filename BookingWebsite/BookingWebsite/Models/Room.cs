using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingWebsite.Models
{
    public class Room
    {
        public string Name { get; set; }
        public string Grade { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }
        public bool Smoker { get; set; }
        public bool Breakfast { get; set; }
        public bool Wifi { get; set; }
    }
}
