using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency;

namespace TravelAgencyTests
{
    public class TourScheduleStub : ITourSchedule
    {
      

        public List<Tour> Tours { get; set; }
        public List<DateTime> Dates { get; set; }


        public List<DateTime> CallsToGetToursFor;

        public TourScheduleStub()
        {

        }
        public void CreateTour(string nameoftour, DateTime tourDateTime, int numberofseats)
        {

        }

        public List<Tour> GetToursFor(DateTime dateTime)
        {
            Dates.Add(dateTime);
            return Tours;
        }
    }
}
