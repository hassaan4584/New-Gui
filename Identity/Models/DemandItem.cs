using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class DemandItem
    {
        [Key]
        [Display(Name = "Demand Id")]
        public int DemandID { get; set; }

        [Display(Name = "Name")]
        public string ItemName { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Issued By")]
        public string Issued_by { get; set; }

        [Display(Name = "Issue Date")]
        public DateTime Issue_Date { get; set; }

        [Display(Name = "Status")]
        public string current_status { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }


    }
}