using Student_Crud_Ajax_Model.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Crud_Ajax_Model
{
   public class Studentcustom
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Fname is mndotary")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lname is mndotary")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Address is mndotary")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Phonenumber is mndotary")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "Gender is mndotary")]
        public string Gender { get; set; }
       
        [Required(ErrorMessage = "Date is mndotary")]
        public DateTime Date { get; set; }


        public RoleType UTYPE { get; set; }
        public bool IsDelete  { get; set; }
      

    }
}
