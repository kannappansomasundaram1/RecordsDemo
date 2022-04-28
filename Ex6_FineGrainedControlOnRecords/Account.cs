using System.Collections.Immutable;

//Immutable all the way through
public record Account
(
    CurrencyCode Currency,
    AccountStatus Status = AccountStatus.Requested,
    decimal AllowedOverdraft = 0m,
    IEnumerable<Transaction> Transactions = null
)
{
    public CurrencyCode CurrencyCode { get; } = Currency;

    public IEnumerable<Transaction> Transactions { get; init; }
        = ImmutableList.CreateRange
            (Transactions ?? Enumerable.Empty<Transaction>());
}
