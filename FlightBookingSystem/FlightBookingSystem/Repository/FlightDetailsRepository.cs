using demo1.Models;
using FlightBookingSystem.Repository;
using FlightBookingSystem_Capgemini.Repository;
using Microsoft.EntityFrameworkCore;

namespace FlightBookingSystem.Models
{

    public class FlightDetailsRepository : IFlightDetailsRepository
    {
        private readonly ModelContext dbcontext;

        public FlightDetailsRepository(ModelContext dbcontext) 
        {
            this.dbcontext = dbcontext;
        }
        public async Task<Flight_Details> CheckAvailibility(string FlightFrom, string FlightTo, DateTime Departure)
        {
            var flight = await dbcontext.Flights.FirstOrDefaultAsync(x => (x.FlightFrom == FlightFrom) && (x.FlightTo == FlightTo) && (x.DepartureDate == Departure));
            return (flight);
        }

        public async Task<List<Flight_Details>> GetFlight_Details()
        {
            return await dbcontext.Flights.ToListAsync();
        }

       
        

    }
}