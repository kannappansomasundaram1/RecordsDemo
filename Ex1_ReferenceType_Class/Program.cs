var me = new Person
{
    Name = "Kannappan",
    Location = "UK"
};

var myClone = new Person
{
    Name = "Kannappan",
    Location = "UK"
};

//Equality
Console.WriteLine($"Are me and my clone are equal? {me.Equals(myClone)}");
Console.WriteLine(me);

public class Person
{
    public string Name { get; set; }
    public string Location { get; set; }
}