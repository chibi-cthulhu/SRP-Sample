using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherBank_SRP
{
    public interface IBankAccount
    {
        string AccountNumber { get; set; }
        decimal AccountBalance { get; set; }
    }
}
