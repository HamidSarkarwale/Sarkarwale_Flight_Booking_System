using demo1.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace FlightBookingSystem.Models
{
    public class BookingDetails
    {
        [Key]
        public int BookingId { set;get; }
        //---------------------------------------
        [Required]
        [ForeignKey("PassengerId")]
        public int PassengerId { set;get; }
        //-------------------------------------------

        [ForeignKey("FlightId")]
        [Required(ErrorMessage ="Enter Flight id")]
        [Display(Name="Flight ID")]
        public int FlightId { set;get; }
        //-----------------------------------------------

        [Required(ErrorMessage ="Enter Flight Name")]
        [Display(Name = "Flight Name")]
        public string FlightName { set; get; }
        //----------------------------------------------

        [Required]
        public string FlightFrom { set;get; }
        //-----------------------------------------
        [Required]
        public string FlightTo { set; get;}
        //-----------------------------------------
        [Required]
        public DateTime DepartureDate { set; get; }
        //------------------------------------------
        [Required]
        public string DepartureTime { set; get; }
        //-----------------------------------------------
        [Required]
        [Display(Name ="Seat Type")]
        public string SeatType { set; get; }
        //------------------------------------------------
        [ForeignKey("SeatNo")]
        public int SeatNo { set; get; }

        //Navigation Properties
        public Flight_Details Flight_Details { set; get; }
        public Passenger Passenger { get; set; }

        public Seat Seat { get; set; }
    }


}
