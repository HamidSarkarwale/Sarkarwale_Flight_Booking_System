using FlightBookingSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace demo1.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
        {

        }
        public DbSet<Flight_Details> Flights { get; set; }
        public DbSet<Seat> seats { get; set; }
        public DbSet<BookingDetails> BookingDetails { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Passenger> passengers { get; set; }
        public DbSet<Admin> admins { get; set; }
    }
}
