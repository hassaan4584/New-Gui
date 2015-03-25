using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class Vendor
    {
        [Key]
        [Display(Name = "Vendor Id")]
        public int VendorID { get; set; }

        [Display(Name = "Name")]
        public String Name { get; set; }

        [Display(Name = "Mobile No.")]
        public String MobileNumber { get; set; }

        [Display(Name = "Email Address")]
        public String Email { get; set; }

        [Display(Name = "Landline No.")]
        public String TelephoneNumber { get; set; }

        [Display(Name = "Category")]
        public String Category { get; set; }

        [Display(Name = "Ratings")]
        public String Rating { get; set; }

        [Display(Name = "Address")]
        public String address { get; set; }

        [Display(Name = "Other Details")]
        public String OtherVendorDetails { get; set; }
    }
}