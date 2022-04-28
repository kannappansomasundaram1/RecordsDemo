var account = new Account(
    Currency: "GBP",
    Status: AccountStatus.Requested,
    AllowedOverdraft: 500.00m,
    Transactions: new List<Transaction>
    {
        new(100m, "Atm Deposit", DateOnly.FromDateTime(DateTime.Today.AddDays(-1)))
    });

Console.WriteLine("---Printing Account Details----");
Console.WriteLine(account);
foreach (var transaction in account.Transactions)
{
    Console.WriteLine(transaction);
}

var anotherAccount = account with
{
//Currency = "EUR", Error
    AllowedOverdraft = 200.00m,
    Transactions = new List<Transaction>
    {
        new(-200m, "Cash withdrawal", DateOnly.FromDateTime(DateTime.Today))
    }
};

Console.WriteLine("---Printing Another Account Details----");
Console.WriteLine(anotherAccount);
foreach (var transaction in anotherAccount.Transactions)
{
    Console.WriteLine(transaction);
}
