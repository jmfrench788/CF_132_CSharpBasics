using System.Collections.Generic;
//Here is what not to do
object[] stuff = new object[5];
stuff[0]= "Terry";
stuff[1]= 1;
stuff[2]= 44.75f;
stuff[3]= "Bill bob";

//We need type safety
//Array - These are always fixed values
string stringExample = "Hello";
//This is a collection of char

string[] stringArray = 
{
    "Hello",
    "World",
    "Why",
    "is it",
    "always",
    stringExample,
    "?"
};

string thirdItem = stringArray[3]; //output should be "is it"

System.Console.WriteLine(thirdItem);

//change the value of first item in stringArray[]
stringArray[0]="Hey";
System.Console.WriteLine(stringArray[0]);

//Lists
//can only be used with system.collections.generic (using statement)
List<string> listOfStrings = new List<string>();
List<int> listOfIntegers = new List<int>();

listOfStrings.Add("First string in our list");
listOfIntegers.Add(46210);

System.Console.WriteLine(listOfIntegers[0]);

//Queues
//Whoever is first in line is first to be serviced
Queue<string> firstInFirstOut = new Queue<string>();

//this is to add to the queue
firstInFirstOut.Enqueue("I'm first");
firstInFirstOut.Enqueue("I'm second");

//to see who is next in line
string seeWhoseNext = firstInFirstOut.Peek();
System.Console.WriteLine(seeWhoseNext);

//removing an item
//We cannot remove any item
//We can only remove who is first

string removedItem = firstInFirstOut.Dequeue();
System.Console.WriteLine($"removed: {removedItem}");

//making sure value was removed
string whoIsNext = firstInFirstOut.Peek();
System.Console.WriteLine($"Next: {whoIsNext}");
System.Console.WriteLine();

//dotnet watch run - it will rerun program when saved
//ctrl+c exits it

//Dictionaries <TKey,TValue>
//There can only be one key
Dictionary<int,string> keyAndValue = new Dictionary<int, string>();

//Add to the dictionary

keyAndValue.Add (7,"Agent");

string valueSeven = keyAndValue[7];
System.Console.WriteLine(valueSeven); //This should give "Agent"

//Other Collections
SortedList<int,string> sortedKeyAndValue = new SortedList<int, string>();
HashSet<int> uniqueList = new HashSet<int>(); //does not allow you to add values that already exist in
Stack<string> lastInFirstOut = new Stack<string>();

//How to deal with random numbers
Random rng = new Random();
//int randomNumber = rng.Next();
int randomNumber = rng.Next(5,20); //Can get between 5 and 20, excluding 5, including 20
System.Console.WriteLine(randomNumber);