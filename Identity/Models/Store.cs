using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class Store
    {
        [Display(Name = "Added Date")]
        public DateTime AddedDate { get; set; }

        [Display(Name = "Item Id")]
        public int itemID { get; set; } //foreign key to item
  
    }
}