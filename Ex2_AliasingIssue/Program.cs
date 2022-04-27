var me = new Person
{
    Name = "Kannappan",
    Location = "UK"
};

//Mutation or Aliasing Problem
var myClone = me;
myClone.Location = "India";

Console.WriteLine($"Where am I? {me.Location}");
Console.WriteLine($"Where is my clone? {myClone.Location}");

public class Person
{
    public string Name { get; set; }
    public string Location { get; set; }
}