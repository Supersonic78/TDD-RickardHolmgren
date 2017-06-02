using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class Exceptions
    {
        public class TourAllocationException : Exception
        {

        }
        public class SameNameSameDateException : Exception
        {

        }

        public class NegativeSeatException : Exception
        {

        }

        public class BookingPersonOnTourWhereNoSeatsLeftException : Exception
        {

        }
        public class BookingPersonOnNonexistentTourException : Exception
        {
            public BookingPersonOnNonexistentTourException(string message) : base(message)
            {
            }
        }
    }
}
