﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concete
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string District { get; set; } // İlçe ya da Semt
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public int ConfirmCode { get; set; }
        public List<CustomerAccount> CustomerAccounts { get; set; }

    }
}
