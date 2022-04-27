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

Console.WriteLine("-------Assignment---------");
myClone = me;
myClone.Location = "India";

Console.WriteLine($"Where am I? {me.Location}");
Console.WriteLine($"Where is my clone? {myClone.Location}");

public struct Person
{
    public string Name { get; set; }
    public string Location { get; set; }
}

