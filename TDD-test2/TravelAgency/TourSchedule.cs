using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TravelAgency
{
    public class TourSchedule
    {
        List<Tour> tours { get; set; } = new List<Tour>();

        public void CreateTour(string name, DateTime date, int seats)
        {
            var chosenDate = new DateTime(date.Year, date.Month, date.Day);
            var toursWithSameDate = tours.Where(x => x.Date == chosenDate).ToList();

            if (toursWithSameDate.Count >= 2)
            {
                throw new Exceptions.TourAllocationException();
            }
            else
            {
                tours.Add(new Tour(name, chosenDate, seats));
            }

        }
        public List<Tour> GetToursFor(DateTime dateTime)
        {
            var chosenDate = tours.Where(x => x.Date == dateTime).ToList();
            return chosenDate;
        }
    }
}
