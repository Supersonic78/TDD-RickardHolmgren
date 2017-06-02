using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency;
using NUnit.Framework;


namespace TravelAgencyTests
{
    class BookingSystemTests
    {

        private BookingSystem sut;
        private TourScheduleStub tourScheduleStub { get; set; }
        private Passenger StubPassenger;


        [SetUp]
        public void Setup()
        {
            tourScheduleStub = new TourScheduleStub();
            sut = new BookingSystem(tourScheduleStub);
            StubPassenger = new Passenger()
            {
                FirstName = "Torsten",
                LastName = "Torsk"
            };
        }

        [Test]
        public void CanCreateBooking()
        {
            //Arrange
            tourScheduleStub.Tours = new List<Tour>();
            tourScheduleStub.Tours.Add(new Tour
            {
                
                NameOfTour = "Torstens Tour",
                DateOfTour = new DateTime(2018, 2, 1),
                NumberOfSeats = 10
            });

            //Act
            sut.CreateBooking("Torstens Tour", new DateTime(2018, 1, 1), 10, StubPassenger);

            List<Booking> bookingsList = sut.GetBookingsFor(StubPassenger);

            //Assert
            var model = bookingsList[0];

            Assert.AreEqual(1, bookingsList.Count);
            Assert.AreEqual("Torstens Tour", model.TourName);
            Assert.AreEqual(StubPassenger, model.passenger);
            Assert.AreEqual(tourScheduleStub.Tours[0].NameOfTour, model.TourName);

        }
        [Test]
        public void BookingAPassengerOnANonExistentTourThrowsException()
        {
            //Arrange
            tourScheduleStub.Tours = new List<Tour>();

            //Act

            //Assert
           
            Assert.Throws<Exceptions.BookingPersonOnNonexistentTourException>(() =>
            sut.CreateBooking("Some Tour", new DateTime(2018, 2, 1), 10, StubPassenger));
        }
        [Test]
        public void BookingAPassengerOnTourWithNoSeatsLeftThrowsException()
        {
            //Arrange
            tourScheduleStub.Tours = new List<Tour>();
            tourScheduleStub.Tours.Add(new Tour
            {
                NameOfTour = "Tour",
                DateOfTour = new DateTime(2019, 7, 7),
                NumberOfSeats = 10
            });

            //Act
            //Assert
            Assert.Throws<Exceptions.BookingPersonOnTourWhereNoSeatsLeftException>(() =>
                sut.CreateBooking("Tour", new DateTime(2018, 1, 1), 12, StubPassenger));
        }

    }
}
