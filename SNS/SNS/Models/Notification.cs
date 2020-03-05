using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SNS.Models
{
    public class Notification
    {

        public int NotificationId { get; set; }
        [Required]
        [Display(Name = "Subject")]
        public string Subject { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required, Range(1,5, ErrorMessage ="Acceptable values are between 1 and 5 inclusive"), Display(Name ="Severity"),]
        public int Severity { get; set; }

        public string Department { get; set; }
       // public enum Departments { Development, Marketing, Support }

    }
}
