namespace BankApplication
{
    public class BankAccount
    {
 private static int accountNumberSeed = 1234567890;
//         public BankAccount(string name, decimal initialBalance)
// {
//   //  this.Owner = name;
//    // this.Balance = initialBalance;
//     this.Number = accountNumberSeed.ToString();
// accountNumberSeed++;
// }   
        

        public string? Number ;

        public string? Owner ;
        public decimal Balance= accountNumberSeed;

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }
    }
}
