using FlightBookingSystem.Models;

namespace FlightBookingSystem_Capgemini.Repository
{
    public interface IFlightDetailsRepository
    {
        Task<List<Flight_Details>> GetFlight_Details();
        Task<Flight_Details> CheckAvailibility(string FlightFrom, string FlightTo, DateTime Departure);

    }
}
