// See https://aka.ms/new-console-template for more information
using Objects_Stone_Evan;
using System.Xml;

Console.WriteLine("Program 17"); // writes program #

Computer myComputer = new Computer("Dell", "Laptop", true); //sets up myComputer based on Computer with filled out data
IBootUp myBootUp = myComputer; //sets up myBootUp based on IBootUp and IsOn equals myComputer
Console.WriteLine(myComputer.Equals(myBootUp));  //writes line saying weither myComputer's IsOne equals myBootUp

Computer myOtherComputer = new Computer("Dell", "Laptop", true); //sets up myOtherComputer based on Computer with filled out data
Console.WriteLine(myComputer.Equals(myOtherComputer)); //writes line saying weither myComputer equals myOtherComputer

string myString = myComputer.ToString(); //creates myString and defines it as myComputer as a string value
string myOtherString = myString; //creates myOtherString and makes it equal to myOtherString

myString = "Hi!"; //makes myString equal the string "Hi!"

Console.WriteLine(myString); //writes myString
Console.WriteLine(myOtherString); //writes myOtherString

Console.WriteLine(myString == myComputer.ToString()); //writes weither myString equals myComputer as a string
Console.WriteLine(myString == myOtherComputer.ToString()); //writes weither myString equals myComputer as a string

Console.WriteLine(myComputer.GetType()); //writes the type of myComputer
Console.WriteLine(myBootUp.GetType()); //writes the type of myOtherComputer

myOtherComputer.PowerOnOff(); //activates myOtherComputer's PowerOnOff

Console.WriteLine(myString == myOtherComputer.ToString()); //writes weither myString equals myOtherComputer as a string
Console.WriteLine(myString); //writes myString
Console.WriteLine(myOtherComputer.ToString()); //writes myOtherComputer as a string

Console.WriteLine(myString.Contains('i')); //writes weither myString contains a 'i'

Console.WriteLine(myString.ToUpper()); //writes myString all capitleized 