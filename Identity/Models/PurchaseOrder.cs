using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class PurchaseOrder
    {
        [Key]
        [Display(Name = "Purchase Order No.")]
        public int PurchaseOrderID { get; set; }

        [Display(Name = "Purchse Request No.")]
        public int PRID { get; set; } //foreign Key

        [Display(Name = "Vendor")]
        public int VendorID { get; set; } //foreign key

        [Display(Name = "Vendor Name")]
        public String VendorName { get; set; }

        [Display(Name = "Budget")]
        public int ApprovedBudget { get; set; }

        [Display(Name = "Estimated Delivery Date")]
        public DateTime EstimatedDeliveryDate { get; set; }

        [Display(Name = "Other Details")]
        public String OtherPurchaseOrderDetails { get; set; }
        
    }
}