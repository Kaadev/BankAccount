using Classes;

/* Você usou Abstração quando definiu classes para cada um dos diferentes tipos de conta. 
Essas classes descrevem o comportamento desse tipo de conta.
Você usou Encapsulamento ao manter muitos detalhes em cada classe.
Você usou Herança ao aproveitar a implementação já criada na classe para salvar o código.
Você usou o Polimorfismo quando criou métodos que as classes derivadas poderiam substituir 
para criar um comportamento específico para esse tipo de conta.*/

/* TESTE 1
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
Console.WriteLine(account1.GetAccountHistory());*/


/*TESTE 2
Test that the initial balances must be positive.
BankAccount invalidAccount;
try
{
  invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
  Console.WriteLine("Exception caught creating account with negative balance");
  Console.WriteLine(e.ToString());
  return;
}

Test for a negative balance.
try
  {
    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
  }
  catch (InvalidOperationException e)
  {
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString());
  }*/


//TESTE 3
var giftCard = new GiftCardAccount("gift card", 100, 50);
giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
giftCard.PerformMonthEndTransactions();
// can make additional deposits:
giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
Console.WriteLine(giftCard.GetAccountHistory());

var savings = new InterestEarningAccount("savings account", 10000);
savings.MakeDeposit(750, DateTime.Now, "save some money");
savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
savings.PerformMonthEndTransactions();
Console.WriteLine(savings.GetAccountHistory());

// //TESTE 4
// var lineOfCredit = new LineOfCreditAccount("line of credit", 0);
// // How much is too much to borrow?
// lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
// lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
// lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
// lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
// lineOfCredit.PerformMonthEndTransactions();
// Console.WriteLine(lineOfCredit.GetAccountHistory());

/* TESTE 5
var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
// How much is too much to borrow?
lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
lineOfCredit.PerformMonthEndTransactions();
Console.WriteLine(lineOfCredit.GetAccountHistory());*/
