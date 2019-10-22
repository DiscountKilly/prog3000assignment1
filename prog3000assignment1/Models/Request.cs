using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prog3000assignment1.Models
{

    public enum EquipCategory { Laptop, Phone, Tablet, Another }
    public class Request
    {
        [Required(ErrorMessage = "Enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter a phone number")]
        [RegularExpression("^[0-9]{3}[0-9]{3}[0-9]{4}$", ErrorMessage = "Enver a valid phone number (xxx-xxx-xxxx)")]
        public string PhoneNum { get; set; }
        [Required(ErrorMessage = "Choose a role")]
        public string Role { get; set; }
        [Required(ErrorMessage = "Choose an equipment")]
        public EquipCategory EquipmentCat { get; set; }
        public string RequestDetails { get; set; }
        [Required(ErrorMessage = "Enter a duration in days")]
        public int RequestDuration { get; set; }
        public int RequestID { get; set; }
    }
}
