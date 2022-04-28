namespace Ex4_Records;


public record class Person(string Name, string Location);

//Another way to define record
// public record Person
// {
//     public string Name { get; init; }
//
//     public string Location { get; init; }
// }
