var accountState = new AccountState(
    Currency: "GBP",
    Status: AccountStatus.Requested,
    AllowedOverdraft: 500.00m,
    Transactions: new List<Transaction>
    {
        new(100m, "Atm Deposit", DateOnly.FromDateTime(DateTime.Today.AddDays(-1)))
    });
Console.WriteLine(accountState);


var anotherAccount = accountState with
{
//Currency = "EUR", Error
    AllowedOverdraft = 200.00m,
    Transactions = new List<Transaction>
    {
        new(-200m, "Cash withdrawal", DateOnly.FromDateTime(DateTime.Today))
    }
};

Console.WriteLine(anotherAccount);