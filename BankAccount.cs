/* COMPORTAMENTOS DA CLASSE BankAccount:

-Ela tem um número com 10 dígitos que identifica exclusivamente a conta bancária.
-Ela tem uma cadeia de caracteres que armazena o nome ou os nomes dos proprietários.
-O saldo pode ser recuperado.
-Ela aceita depósitos.
-Ele aceita saques.
-O saldo inicial deve ser positivo.
-Os saques não podem resultar em um saldo negativo.*/

namespace Classes;

public class BankAccount // Classe
{
  private static int accountNumberSeed = 1234567890; // Campo private: só pode ser acessado pelo código dentro da classe BankAccount. & Static: é compartilhado por todos os objetos BankAccount. 
  public string Number { get; } // Propriedades são elementos de dados que podem ter um código que impõe a validação ou outras regras.
  public string Owner { get; set; }  // Propriedades
  public decimal Balance // Essa propriedade calcula o saldo quando outro programador solicita o valor. Seu cálculo enumera todas as transações e fornece a soma como o saldo atual.
  {
    get
    {
      decimal balance = 0;
      foreach (var item in allTransactions)
      {
        balance += item.Amount;
      }
      return balance;
    }
  }

  public BankAccount(string name, decimal initialBalance) // Construtor: Mesmo nome que a classe, são chamados quando você cria um objeto usando new.
  {
    Number = accountNumberSeed.ToString(); // algoritimo responsável por atribuir N° a conta bancária
    accountNumberSeed++;

    Owner = name;
    MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
  }

  private List<Transaction> allTransactions = new List<Transaction>(); // Lista de transações

  public void MakeDeposit(decimal amount, DateTime date, string note) // métodos (blocos de código que executam uma única função) lançará uma exceção se a quantidade do depósito não for maior que 0.
  {
    if (amount <= 0)
    {
      throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
    }
    var deposit = new Transaction(amount, date, note);
    allTransactions.Add(deposit);
  }

  public void MakeWithdrawal(decimal amount, DateTime date, string note) // métodos (blocos de código que executam uma única função). gera uma exceção se a quantidade de retirada não for maior que 0 ou se a aplicação da retirada resultar em um saldo negativo
  {
    if (amount <= 0)
    {
      throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive"); // exceção
    }
    if (Balance - amount < 0)
    {
      throw new InvalidOperationException("Not sufficient funds for this withdrawal"); // exceção
    }
    var withdrawal = new Transaction(-amount, date, note);
    allTransactions.Add(withdrawal);
  }
  public string GetAccountHistory()
  {
    var report = new System.Text.StringBuilder();

    decimal balance = 0;
    report.AppendLine("Date\t\tAmount\tBalance\tNote");
    foreach (var item in allTransactions)
    {
      balance += item.Amount;
      report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
    }

    return report.ToString();
  }
}

