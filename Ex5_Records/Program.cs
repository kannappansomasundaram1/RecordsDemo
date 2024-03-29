﻿using Ex4_Records;

var me = new Person("Kannappan", "UK");
var myClone = new Person("Kannappan", "UK");

Console.WriteLine("-------Equality-------");
Console.WriteLine($"Are me and my clone the same? {me.Equals(myClone)}");
Console.WriteLine($"Reference Equal? {ReferenceEquals(me,myClone)}");

Console.WriteLine("-------ToString()-------");
Console.WriteLine(me);

Console.WriteLine("-------Immutability-------");
myClone = me with { Location = "India" };

Console.WriteLine($"Where am I? {me.Location}");
Console.WriteLine($"Where is my clone? {myClone.Location}");
Console.WriteLine($"Equal? {me.Equals(myClone)}");

Console.WriteLine("-------Deconstruction-------");
var (name1, location) = me;

Console.WriteLine($"My name: {name1}");
Console.WriteLine($"My Location: {location}");
