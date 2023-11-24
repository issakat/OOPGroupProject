using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    internal class BookingManager
    {
            private List<BookingReservation> availableBookings;
        private List<BookingReservation> deletedBookings;

        public BookingManager()
        {
            availableBookings = new List<BookingReservation>();
            deletedBookings = new List<BookingReservation>();
        }

        public void MakeBooking(int customerID, int flightNumber, string dateOfBooking)
        {
            BookingReservation newBooking = new BookingReservation(customerID, flightNumber, dateOfBooking);
            availableBookings.Add(newBooking);
            Console.WriteLine("Booking successful!");
        }

        public void DeleteBooking(int bookingNumber)
        {
            BookingReservation bookingToDelete = availableBookings.Find(booking => booking.ReservationNumber == bookingNumber);

            if (bookingToDelete != null)
            {
                availableBookings.Remove(bookingToDelete);
                deletedBookings.Add(bookingToDelete);
                Console.WriteLine("Booking deleted successfully.");
            }
            else
            {
                Console.WriteLine("Booking not found.");
            }
        }

        public List<BookingReservation> ViewAllBookings()
        {
            return availableBookings;
        }

        public List<BookingReservation> ViewDeletedBookings()
        {
            return deletedBookings;
        }
    }
}
