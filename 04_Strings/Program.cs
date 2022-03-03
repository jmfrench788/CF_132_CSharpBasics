//Strings

//Just a collection of characters stored and used throughout an application in different ways
//Almost any text, single character, or number can be a string

//In C# we can initialize string by using double quotes "  " around the value

//3 ways to use a string type
    //1. Concatenation
    //2. Composite Formatting
    //3. Interpolaton

//Concatenation
string first = "The cars we sell are ";
string second = "Toyota, BMW, and Lexus.";
string concatenateResult = first + second;
System.Console.WriteLine(concatenateResult);

//Composit formatting
//using {} inside of the string itself with a number inside the braces
string firstName = "Julia";
string lastName = "French";

string compositeResult = string.Format ("Her name is {0} {1}",firstName, lastName);
System.Console.WriteLine(compositeResult);


//String Interpolation

string interpolationResult = $"Her name is still {firstName} {lastName}.";
System.Console.WriteLine(interpolationResult);

//Challenge 1

string one = "Hello";
string two = "World";
System.Console.WriteLine(one + " " + two);

string composite = string.Format ("{0} {1}", one, two);
System.Console.WriteLine(composite);

string interpolation = $"{one} {two} :) ";
System.Console.WriteLine(interpolation);

//Challenge 2
string day = "10";
string month = "September";
System.Console.WriteLine("My birthday is " + day + " " + month);

string composite2 = string.Format ("My birthday is {0} {1}", day, month);
System.Console.WriteLine(composite2);

string interpolation2 = $"My birthday is {day} {month}";
System.Console.WriteLine(interpolation2);



