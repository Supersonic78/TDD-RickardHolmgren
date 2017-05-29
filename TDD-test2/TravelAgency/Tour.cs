using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class Tour
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Seats { get; set; }

        public Tour(string name, DateTime date, int seats)
        {
            Name = name;
            Date = date;
            Seats = seats;
        }
    }
}
