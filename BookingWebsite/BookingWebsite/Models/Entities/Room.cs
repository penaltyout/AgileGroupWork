using System;
using System.Collections.Generic;

namespace BookingWebsite.Models.Entities
{
    public partial class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }
        public bool Smoker { get; set; }
        public bool Breakfast { get; set; }
        public bool Wifi { get; set; }
    }
}
