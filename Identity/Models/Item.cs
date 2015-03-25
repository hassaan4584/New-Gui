using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class Item
    {
        [Key]
        [Display(Name = "Item Id")]
        public int ItemID { get; set; }

        [Display(Name = "Item Name")]
        public String Name { get; set; }

        [Display(Name = "Item Desription")]
        public String Description { get; set; }

        [Display(Name = "Item Category")]
        public String Category { get; set; }

        [Display(Name = "Current Value")]
        public int CurrentlyPresent { get; set; }

        [Display(Name = "Minimum Value")]
        public int ReorderLevel { get; set; }

        [Display(Name = "SKU")]
        public String StockKeepingUnit { get; set; }

        [Display(Name = "Other Details")]
        public String OtherItemDetails { get; set; }
    }
}