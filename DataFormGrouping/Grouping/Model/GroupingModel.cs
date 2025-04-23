using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Grouping
{
    public class GroupingModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; } = string.Empty;

        [Display(Name = "Mobile Number", GroupName = "Details")]
        public string MobileNumber { get; set; } = string.Empty;

        [Display(Name = "Landline Number", GroupName = "Details")]
        public string LandlineNumber { get; set; } = string.Empty;

        [Display(Name = "Email", GroupName = "Details")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Address", GroupName = "Details")]
        public string Address { get; set; } = string.Empty;

    }
}
