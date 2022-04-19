
using BankApplication;

var account = new BankAccount();
account.Owner="Harsh";
account.Balance = 1000000m;
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");