using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Models.Models
{
    public class UserModel
    {
        public int id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Password length should be between 1 and 50", MinimumLength = 1)]
        [RegularExpression(@"^[a-zA-Z]+$",ErrorMessage ="Enter alphabets only")]
        [Display(Name ="First Name")]
        public string firstName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Password length should be between 1 and 50", MinimumLength = 1)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Enter alphabets only")]
        [Display(Name = "Last Name")]

        public string lastName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z\d_]+@[a-zA-Z]+\.[a-zA-Z]+$", ErrorMessage = "Enter valid email")]
        [Display(Name = "Email")]

        public string email { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="Password length should be between 5 and 50",MinimumLength =5)]
        [Display(Name = "Password")]

        public string password { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Confirm Password length should be between 5 and 50", MinimumLength = 5)]
        [Compare("password",ErrorMessage ="Enter same as password")]
        [Display(Name = "Confirm Password")]

        public string confirmPassword { get; set; }
    }
}
