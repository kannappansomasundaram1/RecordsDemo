namespace Ex6_CustomTypes;

public record Age(int value)
{
    private int Value { get; } = IsValid(value) ? value :
        throw new ArgumentException($"{value} is not a valid age");

    private static bool IsValid(int age)
        => age is >= 0 and < 120;

    public static bool operator <(Age l, int r)
        => l < new Age(r);
    public static bool operator >(Age l, int r)
        => l > new Age(r);

    public static implicit operator int(Age age)
        => age.Value;
    public static implicit operator Age(int age)
        => new (age);
}