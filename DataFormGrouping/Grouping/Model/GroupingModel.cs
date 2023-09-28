using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Grouping
{
    public class GroupingModel
    {
        [Display(Name="First Name")]  
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name="Mobile Number",GroupName ="Details")]
        public string MobileNumber { get; set; }

        [Display(Name = "Landline Number", GroupName = "Details")]
        public string LandlineNumber { get; set; }

        [Display(Name="Email", GroupName = "Details")]
        public string Email { get; set; }
       
        [Display(Name ="Address", GroupName = "Details")]
        public string Address { get; set; }

    }
}
