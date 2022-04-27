using Ex6_CustomTypes;
using static System.Console;

new List<int> { 28, 65 }
    .ForEach(age =>
        WriteLine($"Risk Profile of Person with Age {age}: { CalculateRiskProfile(age) }"));


Risk CalculateRiskProfile(Age age)
    => age < 60 ? Risk.Low : Risk.Medium;

//Guaranteeing that only valid values can be given
//Removing the need for duplicating validation wherever an age is processed
//Constrain the inputs of your functions, it’s usually better to define a custom type

public enum Risk
{
    Low,
    Medium
}