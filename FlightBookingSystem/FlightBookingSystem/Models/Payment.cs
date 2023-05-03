using FlightBookingSystem.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo1.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        [ForeignKey("BookingId")]
        public int BookingId { get; set; }


        


        [Required]
        [StringLength(50)]
        public string? PaymentStatus { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int TotalAmount { get; set; }

        public BookingDetails bookingDetails { get; set; }
    }
}