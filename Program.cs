using Classes;

var account = new BankAccount("<Bruno>", 1000); // criando um a nova conta
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
account.MakeWithdrawal(500, DateTime.Now, "Rent payment"); // Registrando um pagamento
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "Friend paid me back"); // Registrando um recebimento
Console.WriteLine(account.Balance);
Console.WriteLine(account.GetAccountHistory());

var account1 = new BankAccount("Karen", 2000);
Console.WriteLine($"Account {account1.Number} was created for {account1.Owner} with {account1.Balance} initial balance.");
account1.MakeWithdrawal(600, DateTime.Now, "Rent payment");
Console.WriteLine(account1.Balance);
account1.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine(account1.Balance);
Console.WriteLine(account1.GetAccountHistory());



// Test that the initial balances must be positive.
// BankAccount invalidAccount;
// try
// {
//   invalidAccount = new BankAccount("invalid", -55);
// }
// catch (ArgumentOutOfRangeException e)
// {
//   Console.WriteLine("Exception caught creating account with negative balance");
//   Console.WriteLine(e.ToString());
//   return;
// }

// Test for a negative balance.
// try
//   {
//     account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
//   }
//   catch (InvalidOperationException e)
//   {
//     Console.WriteLine("Exception caught trying to overdraw");
//     Console.WriteLine(e.ToString());
//   }

