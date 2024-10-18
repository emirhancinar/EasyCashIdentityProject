using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concete
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string Currency { get; set; } // Döviz Türü
        public decimal CustomerAccountBalance { get; set; }
        public string MyProperty { get; set; }
        public string BankBranch { get; set; } // Banka Şubesi
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }

    }
}
