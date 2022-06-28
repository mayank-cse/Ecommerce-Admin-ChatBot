using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceAdminBot.Models
{
    public class UserProfile
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool UserAuthenticated { get; set; } = false;
        public int OTP { get; set; }
        public string ValueFinder { get; set; }
    }
}
