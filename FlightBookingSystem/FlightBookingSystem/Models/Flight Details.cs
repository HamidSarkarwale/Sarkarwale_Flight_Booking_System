using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FlightBookingSystem.Models
{
    public class Flight_Details
    {
        [Key]
        public int FlightId { set; get; }
        //-----------------------------------------------

        [Required(ErrorMessage ="Enter Flight Name")]
        [Display(Name ="Flight Name")]
        public string? FlightName { set; get;}

        //-------------------------------------------------
        [Required(ErrorMessage ="Provide Boarding Location")]
        [Display(Name ="From City")]
        public string? FlightFrom { set; get; }

        //---------------------------------------------------------
        [Required(ErrorMessage = "Provide Destination Location")]
        [Display(Name="To City")]
        public string? FlightTo { set; get;}

        //---------------------------------------------------------
        [Required]
        [Display(Name = "Departure Date")]
        public DateTime DepartureDate { set; get; }
        //----------------------------------------------

        [Required]
        [Display(Name = "Departure Time")]
        public string DepartureTime { set;get; }
        //------------------------------------------------

        [Required]
        [Display(Name = "Seating Capacity")]
        public int SeatCapacity { set; get; }

        //-------------------------------------------------
        [Required]
        [Display(Name = "Business Class Seat's")]
        public int BusinessClass_SeatCount { set; get; }

        //-------------------------------------------------
        [Required]
        [Display(Name = "Economy Class Seat's")]
        public int EconomyClass_SeatCount { set; get; }

        //----------------------------------------------
        [Required]
        [Display(Name = "Business Class Price")]
        public int BusinessClassPrice { set; get; }

        //-------------------------------------------
        [Required]
        [Display(Name = "Economy Class Price")]
        public int EconomyClassPrice { set; get; }
    }

  
   

}
