using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    internal class ViewBookings : Booking
    {
        private BookingManager bookingManager;

        public ViewBookings(BookingManager manager)
        {
            bookingManager = manager;
        }

        public void View()
        {
            Console.WriteLine("XYZ Airlines Limited - View Bookings");
            Console.WriteLine("Reservation Number \t Customer ID \t Flight Number \t Date of Booking");

            foreach (var booking in bookingManager.ViewAllBookings())
            {
                Console.WriteLine($"{booking.ReservationNumber} \t\t {booking.CustomerID} \t\t {booking.FlightNumber} \t\t {booking.DateOfBooking}");
            }
        }
    }
}

