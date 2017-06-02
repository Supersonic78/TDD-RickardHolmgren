using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TravelAgency;

namespace TravelAgencyTests
{
    [TestFixture]
    class TourScheduleTest
    {
        private TourSchedule sut;
        [SetUp]
        public void Setup()
        {
            sut = new TourSchedule();
        }
        [Test]
        public void CanCreateNewTour()
        {

            sut.CreateTour("New years day safari", new DateTime(2013, 1, 1), 20);

            List<Tour> tours = sut.GetToursFor(new DateTime(2013, 1, 1));

            Assert.AreEqual(1, tours.Count);
            Assert.AreEqual("New years day safari", tours[0].NameOfTour);
            Assert.AreEqual(20, tours[0].NumberOfSeats);
        }

        [Test]
        public void ToursAreScheduledByDateOnly()
        {

            sut.CreateTour("New years day safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);

            var tours = sut.GetToursFor(new DateTime(2013, 1, 1));

            Assert.AreEqual(1, tours.Count);
        }

        [Test]
        public void GetToursForGivenDayOnly()
        {
            sut.CreateTour("safari1", new DateTime(2013, 1, 1), 20);
            sut.CreateTour("Safari2", new DateTime(2013, 1, 2), 20);
            sut.CreateTour("Safari3", new DateTime(2013, 1, 2), 20);
            sut.CreateTour("Safari4", new DateTime(2013, 1, 3), 20);
            sut.CreateTour("Safari5", new DateTime(2013, 1, 4), 20);

            var tours = sut.GetToursFor(new DateTime(2013, 1, 2));

            Assert.AreEqual(2, tours.Count);
        }

        [Test]
        public void ThrowTourAllocationExceptionIfOverBook()
        {
            sut.CreateTour("Safari time", new DateTime(2013, 1, 2), 20);
            sut.CreateTour("Safari time", new DateTime(2013, 1, 2), 20);

            Assert.Throws<Exceptions.TourAllocationException>(() =>
            {
                sut.CreateTour("Safari time", new DateTime(2013, 1, 2), 20);
            });
        }
    }
}
