using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class ActivityLog
    {
        [Key]
        [Display(Name = "Activity Id")]
        public int ActivityLogID { get; set; }

        [Display(Name = "User Id")]
        public int UserID { get; set; } //Foreign Key

        [Display(Name = "User Name")]
        public String UserName { get; set; }

        [Display(Name = "Details")]
        public String ActivityDetails { get; set; }

        [Display(Name = "At")]
        public DateTime Time { get; set; }

    }
}