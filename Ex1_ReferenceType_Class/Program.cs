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
Console.WriteLine($"Are me and my clone are equal? {me.Equals(myClone)}"); //false
Console.WriteLine(me); //Person

public class Person
{
    public string Name { get; set; }
    public string Location { get; set; }
}
