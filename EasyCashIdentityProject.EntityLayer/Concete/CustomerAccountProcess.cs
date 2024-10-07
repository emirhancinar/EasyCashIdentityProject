using System;
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

    }
}
 