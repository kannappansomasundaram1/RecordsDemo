public record CurrencyCode(string value)
{
    private string Value { get; } =
        IsValid(value) ? value : throw new ArgumentException($"{value} is not a valid CurrencyCode");

    private static bool IsValid(string s) => s.Length == 3;

    public static implicit operator string(CurrencyCode c)
        => c.Value;

    public static implicit operator CurrencyCode(string s)
        => new(s);
}