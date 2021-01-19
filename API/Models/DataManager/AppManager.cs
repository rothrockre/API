using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models.DataManager
{
    public class AppManager
    {
        public class UserViewModel
        {
            public int UserID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public bool PaidUser { get; set; }
            public System.DateTime CreateDate { get; set; }
            public string LastUser { get; set; }
            public double Height { get; set; }
            public double Weight { get; set; }
            public bool Lbs_Kilos { get; set; }
            public string Email { get; set; }
        }
    }
}