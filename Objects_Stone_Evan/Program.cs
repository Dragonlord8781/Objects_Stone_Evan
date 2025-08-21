// See https://aka.ms/new-console-template for more information
using Objects_Stone_Evan;

Console.WriteLine("Program 17");

Computer myComputer = new Computer("Apple", "All-in-One", true);
IBootUp myBootUp = myComputer;
Console.WriteLine(myComputer.Equals(myBootUp)); 

Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
Console.WriteLine(myComputer.Equals(myOtherComputer));

string myString = myComputer.ToString();
Console.WriteLine(myString == myComputer.ToString());
Console.WriteLine(myString == myOtherComputer.ToString());

Console.WriteLine(myComputer.GetType());
Console.WriteLine(myBootUp.GetType());

myOtherComputer.PowerOnOff();

if
