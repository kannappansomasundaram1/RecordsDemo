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

Console.WriteLine($"Are me and my clone the same? {me.Equals(myClone)}");
Console.WriteLine(me);

//Fixing the Aliasing Problem
// myClone = me;
// // Below line will Error since we made the properties as init only
// myClone.Location = "India";

myClone = new Person
{
    Name = me.Name,
    Location = "India"
};

Console.WriteLine($"Where am I? {me.Location}");
Console.WriteLine($"Where is my clone? {myClone.Location}");
