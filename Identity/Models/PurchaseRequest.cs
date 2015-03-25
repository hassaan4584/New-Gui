using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class PurchaseRequest
    {
        [Key]
        [Display(Name = "PR Id")]
        public int PR_ID { get; set; }

        [Display(Name = "Issued By")]
        public string Issued_by { get; set; }

        [Display(Name = "Issue Date")]
        public DateTime Issue_Date { get; set; }

        [Display(Name = "Current Status")]
        public string current_status { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Amount")]
        public string Amount_in_words { get; set; }

        [Display(Name = "Approved Budget")]
        public int Approved_budget { get; set; }

        [Display(Name = "Budget Available")]
        public int Balance_over_budget { get; set; }

        [Display(Name = "Demand Id")]
        public int demandID { get; set; }

        [Display(Name = "Vendor")]
        public string vendorname { get; set; }

        [Display(Name = "Authorized By")]
        public string authorized_by { get; set; }

        [Display(Name = "Verification Date")]
        public DateTime verified_date { get; set; }

        [Display(Name = "Authorization Date")]
        public DateTime Authorization_date { get; set; }
 
    }
}