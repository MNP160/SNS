using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SNS.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the SNSUser class
    public class SNSUser : IdentityUser
    {

        public string Department { get; set; }
    }
}
