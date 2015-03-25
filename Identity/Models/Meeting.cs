using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class Meeting
    {
        [Key]
        [Display(Name = "Meeting Id")]
        public int MeetingID { get; set; }

        [Display(Name = "Agenda")]
        public String agenda { get; set; }

        [Display(Name = "Time")]
        public DateTime time { get; set; }

        [Display(Name = "Venue")]
        public String venue { get; set; }

        [Display(Name = "Caller")]
        public String calledBy { get; set; }
        //        public int prID { get; set; }

        [Display(Name = "Other Details")]
        public String otherMeetingDetails { get; set; }


    }
}