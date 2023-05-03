using System.ComponentModel.DataAnnotations;

namespace demo1.Models
{
    public class Admin
    {
        [Key]
        public int UserId { get; set; }
        //---------------------------------
        [Required]
        [StringLength(50)]
        [Display(Name="Admin Name")]
        public string Name { get; set; }
        //-------------------------------------

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Id")]
        public string EmailId { get; set; }
        //-----------------------------------------
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$",
        ErrorMessage = "Password should be between 8 to 10 characters, and contain at least one lowercase letter, one uppercase letter, one numeric digit, and one special character.")]
        public string Password { get; set; }
    }
}
