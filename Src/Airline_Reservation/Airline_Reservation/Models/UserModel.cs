using System;
using System.ComponentModel.DataAnnotations;

namespace Airline_Reservation.Models
{
    public class UserModel
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "Please Enter User name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter User name")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        public DateTime DOB { get; set; }

        public int Age { get; set; }

        [Required(ErrorMessage = "Please Enter User name")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        public string Address { get; set; }

        [Required(ErrorMessage ="Please Enter User name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }


    }
}
