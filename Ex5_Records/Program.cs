var me = new Person("Kannappan", "UK");
var myClone = new Person("Kannappan", "UK");

Console.WriteLine("-------Equality-------");
Console.WriteLine($"Are me and my clone the same? {me.Equals(myClone)}");

Console.WriteLine("-------ToString()-------");
Console.WriteLine(me);

Console.WriteLine("-------Immutability-------");
myClone = me with { Location = "India" };
Console.WriteLine($"Where am I? {me.Location}");
Console.WriteLine($"Where is my clone? {myClone.Location}");
Console.WriteLine($"{me.Equals(myClone)}");

Console.WriteLine("-------Deconstruction-------");
var (name, location) = me;
Console.WriteLine($"My name: {name}");
Console.WriteLine($"My Location: {location}");

public record class Person(string Name, string Location);
public record struct Person1(string Name, string Location);

