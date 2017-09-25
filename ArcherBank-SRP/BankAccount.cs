using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherBank_SRP
{
    public class BankAccount : IBankAccount
    {
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
