using FlightBookingSystem.Models;

namespace FlightBookingSystem.Repository
{
    public interface IBookingDetailsRepository
    {
        public BookingDetails MakeBooking(BookingDetails bookingDetails);
        public BookingDetails GetBooking(int BookingId);
        public void CancelBooking();
    }
}
