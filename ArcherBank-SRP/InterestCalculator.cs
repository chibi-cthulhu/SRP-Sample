using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherBank_SRP
{
    public class InterestCalculator : IInterestCalculator
    {
        public decimal CalculateInterest(BankAccount account)
        {
            return account.AccountBalance * 11/10;
        }
    }
}
