using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    internal class BookingReservation : Booking
    {
        private static int reservationCounter = 1;

        public int ReservationNumber { get; private set; }
        public int CustomerID { get; set; }
        public int FlightNumber { get; set; }
        public string DateOfBooking { get; set; }

        public BookingReservation(int customerID, int flightNumber, string dateOfBooking)
        {
            ReservationNumber = reservationCounter++;
            CustomerID = customerID;
            FlightNumber = flightNumber;
            DateOfBooking = dateOfBooking;
        }
    }
}
