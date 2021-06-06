using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class EmployeeVM
    {
        public string Id { get; set; }
        [Display(Name = "User name")]
        public string UserName { get; set; }
        [Display(Name = "Email address")]
        public string Email { get; set; }
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "Tax ID number")]
        public string TaxId { get; set; }
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Date joined")]
        public DateTime DateJoined { get; set; }
    }
}
