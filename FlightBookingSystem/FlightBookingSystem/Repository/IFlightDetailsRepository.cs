using FlightBookingSystem.Models;

namespace FlightBookingSystem.Repository
{
    public interface IFlight_DetailsRepository
    {
        //public Flight_Details GetFlight_Details(string FlightFrom, string FlightTo, DateOnly DepartureDate);
        public void SaveFlights(Flight_Details flight);
    }
}
