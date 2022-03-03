//Booleans

//Can hold true or false values

bool isCool = false;
isCool = true;

//boolean logical operators
//operators that perform logical operations and assessments
//These use the keywords and, or, not, etc

//NOT = !
// !isCool evaluates to opposite of whatever value it is holding 

// AND = &
// a single & is going to evaluaton both conditions always
// a double && only evaluated right side if it is required

//OR = | 
// | checks both conditions
// || checks the left side then right side

//XOR = ^ to indicate exclusive-or

bool isTrue = !false;
bool isFalse =!true;

bool trueAnd = true && true;
bool falseAnd = true && false;

bool trueOr = true || false;
bool falseOr = false || false;

bool trueXOR = true ^ false; //this will be true
bool falseXOR = true ^ true; // false
bool falseXOR2 = false ^ false; //false

System.Console.WriteLine($"NOT False = {isTrue}");
System.Console.WriteLine($"False and True = {falseAnd}");
System.Console.WriteLine($"True or True = {trueOr}");
System.Console.WriteLine($"True XOR true = {trueXOR}");
System.Console.WriteLine($"False XOR False = {falseXOR2}");

//Comparison operators

//Equal is ==
//Not equal is !=
//Greater than is >
// less than is <
//Greater than or equal is >=
//less than or equal is <=

bool isGreater = 10 > 10;
bool isGreaterOr = 10 >= 10;
System.Console.WriteLine(isGreater);
System.Console.WriteLine(isGreaterOr);

bool a = true;
bool b = true;
bool c = a == b;
bool d = a != b;
System.Console.WriteLine(c);
System.Console.WriteLine(d);

bool equal = 12 == 9;
bool notequal = 12!=9;
System.Console.WriteLine(equal);
System.Console.WriteLine(notequal);



