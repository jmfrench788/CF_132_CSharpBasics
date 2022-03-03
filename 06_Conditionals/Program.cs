//Conditionals
//operate on conditional statements

//Examples
// if user logs in, then redirect to login page
// If it is user's b-day, then b-day message pops up
// if user enters something not valid, then tell them to try again

bool isRaining = true;
bool isGoingOutside = true;

//p->q statements
//if p = true, do q

//Syntax
//If(true/false value)
//{
    //execute this code if value is true
//}

if (isRaining == true) //or can say if(isRaining)
{
    System.Console.WriteLine("It's raining.");
}

//Can have multiple if statements
if(isRaining && isGoingOutside)
{
    System.Console.WriteLine("Bring an umbrella.");
}

if(isRaining || isGoingOutside == false)
{
    System.Console.WriteLine("I don't need an umbrella.");
}

if(isRaining ^ isGoingOutside)
{
    System.Console.WriteLine("I will go outside if it is not raining.");
}

//Challenge
//write an if statement that uses a new boolean called 'hasUmbrella' that will display text
//to the Console if the user has an umbrella and is going outside while it's raining.
//Example of expected output:
// Good thing I have my umbrella so I can go outside while it's raining!

bool hasUmbrella = true;

if(hasUmbrella && isGoingOutside && isRaining)
{
    System.Console.WriteLine("I have my umbrella to go outside when it is raining.");
}

