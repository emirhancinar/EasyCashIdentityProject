﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concete
{
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessID { get; set; }
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }  //Miktar
        public DateTime ProcessDate { get; set; }
        public int? SenderID { get; set; }
        public int? ReceiverID { get; set; }
        public CustomerAccount SenderCustomer { get; set; }
        public CustomerAccount ReceiverCustomer { get; set; }
        public string Description { get; set; }

    }
}
 