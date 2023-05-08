using FlightBookingSystem.Models;
using FlightBookingSystem_Capgemini.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightBookingSystem_Capgemini.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightBookingDetailsController : ControllerBase
    {
        private readonly IFlightDetailsRepository ifdrepository;

        public FlightBookingDetailsController(IFlightDetailsRepository Ifdrepository)
        {
            ifdrepository = Ifdrepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flight_Details>>> GetAll()
        {
            return await ifdrepository.GetFlight_Details();
        }

        [HttpGet("{FlightFrom}")]
        public async Task<ActionResult<Flight_Details>> GetSearch(string FlightFrom, string FlightTo, DateTime Departure) 
        {
            return await ifdrepository.CheckAvailibility(FlightFrom, FlightTo, Departure);
        }
    }
}
