// Has 3 parts

// 'switch keyword'

// a value that is being evaluated

// 'case' keyword, indicates a new block of code to be executed if the value matches given case

//'break' keyword which indicates end of the case

// 'default' keyword which will run if all else fails


//Real Example
System.Console.WriteLine("How are you feeling today from 1-5?");
int mood = int.Parse(Console.ReadLine());

switch(mood)
{
    case 5:
    System.Console.WriteLine("Great to hear!");
    break;

    case 4:
    System.Console.WriteLine("Good stuff");
    break;

    case 3:
    System.Console.WriteLine("Hope things improve.");
    break;

    case 2:
    System.Console.WriteLine("Sorry to hear that.");
    break;

    case 1:
    System.Console.WriteLine("Hope your day gets better.");
    break;

    default:
    System.Console.WriteLine("Invalid");
    break;
}

//Can add multiple cases before a break
// case 1:
// case 2:
// CODE
// break;

//Challenge 
//Creating a switch statement
//want to output discriptions for a few of your friends

//Prompt the user's input to enter a friends name
//Take in a user's input from the Console
//If the input is one of the listed friends write a fact about that person to the Console

//Extra Challenge:
// what can you do with cases like "Paul" and "paul" as these are different values


System.Console.WriteLine("Enter the first name of someone I know.");
string name = Console.ReadLine();

switch(name)
{
    case "Michael":
    case "michael":
    System.Console.WriteLine("My younger brother.");
    break;

    case "Joe":
    case "joe":
    System.Console.WriteLine("My brother's boyfriend.");
    break;

    case "Fritz":
    case "fritz":
    case "Frank":
    case "frank":
    System.Console.WriteLine("My dad.");
    break;

    case "Shele":
    case "shele":
    case "Michele":
    case "michele":
    System.Console.WriteLine("My mom.");
    break;

    case "Kris":
    case "kris":
    System.Console.WriteLine("My favorite teacher/boss in college and technical theatre.");
    break;

    default:
    System.Console.WriteLine("I don't know them.");
    break;


}
