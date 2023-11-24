using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    internal class Booking
    {
        private BookingManager bookingManager;

        public Booking()
        {
            bookingManager = new BookingManager();
        }

        public void ShowBookingMenu()
        {
            while (true)
            {
                int choice = ShowBookingMenuOptions();

                switch (choice)
                {
                    case 1:
                        ViewBookings();
                        break;
                    case 2:
                        MakeBooking();
                        break;
                    case 3:
                        DeleteBooking();
                        break;
                    case 4:
                        ViewDeletedBookings();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private void ViewBookings()
        {
            Console.WriteLine("XYZ Airlines Limited - View Bookings");
            Console.WriteLine("Reservation Number \t Customer ID \t Flight Number \t Date of Booking");

            foreach (var booking in bookingManager.ViewAllBookings())
            {
                Console.WriteLine($"{booking.ReservationNumber} \t\t {booking.CustomerID} \t\t {booking.FlightNumber} \t\t {booking.DateOfBooking}");
            }
        }

        private void MakeBooking()
        {
            Console.WriteLine("Enter Customer ID:");
            if (int.TryParse(Console.ReadLine(), out int customerID))
            {
                Console.WriteLine("Enter Flight Number:");
                if (int.TryParse(Console.ReadLine(), out int flightNumber))
                {
                    string date = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                    bookingManager.MakeBooking(customerID, flightNumber, date);
                    Console.WriteLine("Booking successful!");
                }
                else
                {
                    Console.WriteLine("Invalid Flight Number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Customer ID.");
            }
        }

        private void DeleteBooking()
        {
            Console.WriteLine("Enter Reservation Number to delete:");
            if (int.TryParse(Console.ReadLine(), out int reservationNumber))
            {
                bookingManager.DeleteBooking(reservationNumber);
            }
            else
            {
                Console.WriteLine("Invalid Reservation Number.");
            }
        }

        private void ViewDeletedBookings()
        {
            Console.WriteLine("Airlines Limited - View Deleted Bookings");
            Console.WriteLine("Reservation Number \t Customer ID \t Flight Number \t Date of Booking");

            foreach (var booking in bookingManager.ViewDeletedBookings())
            {
                Console.WriteLine($"{booking.ReservationNumber} \t\t {booking.CustomerID} \t\t {booking.FlightNumber} \t\t {booking.DateOfBooking}");
            }
        }

        private int ShowBookingMenuOptions()
        {
            Console.WriteLine("Airlines Limited");
            Console.WriteLine("Booking Menu");
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("1. View Bookings");
            Console.WriteLine("2. Make Booking");
            Console.WriteLine("3. Delete Booking");
            Console.WriteLine("4. View Deleted Bookings");
            Console.WriteLine("5. Back to main menu");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 5)
            {
                return choice;
            }

            Console.WriteLine("Invalid input. Please enter a valid option.");
            return -1;
        }
    }
}
