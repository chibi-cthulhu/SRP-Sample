
namespace ArcherBank_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var account = new BankAccount();
                account.AccountBalance = 100;
                account.AccountNumber = "123";

                var handler = new InterestCalculator();
                var result = handler.CalculateInterest(account);
            }
            catch (System.Exception ex)
            {
                ExceptionHandler.LogException(ex, "somestuf");
            }
           
        }
    }
}
