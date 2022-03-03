
//camel-cased first letter of the name is lowerCased and every other name is Capitalized
//bool = true or false

bool isloggedin = true;
System.Console.WriteLine(isloggedin);

//int = whole numbers
int age = 42;
System.Console.WriteLine(age);

//decimal = number with decimals
//need a suffix to show that it is a decimal
decimal accountBalance = 9000.01m; //Can also use _ for commas

int i = 0; //32 bit-integer value
short sh = 32767; //16-bit integer value.
Int16 anotherShortExample = 32000;
byte by = 255; //a group of binary digits (usually 8), operated on as a unit
string s = "Hey!"; //collection of characters (this is a reference type so it defaults to null)
char c = 'i'; //single quotes
string s2 = @"a\tree"; // use the @ specify a directory

bool b = false;

long L = 7; // large integre value. x2 more large
            //-9_223_372_036_854_775_808 to 9_223_372_036_854_775_807


decimal d = 99.999999m; //128-bit precision, range of 28-29 decimal places (MONEY)

double db = 7.80000d; //has 15-16 digit percision with a 64-bit size (d at end for double, which is the default)

float f = 10.8f; //'f' suffix, float is stored in 32-bits, half the size of a double

int? ni = null; //Question mark after data type allows the value to be null.
                //null means 'ni' can have a value or be null

//Dealing with decimals
//We can type as many decimal places as we want for a given type
//but things change during compile time (dotnet run)

Console.WriteLine(1.2578907289045789789789789787897f);
Console.WriteLine(1.2578907289045789789789789787897d);
//Use our PastryTypes
PastryType myPastry = PastryType.Cake;
PastryType anotherOne = PastryType.Cookie;

//All number types in C# are structs(value types)
//They are emutable, you cannot change its initial value. i.e value of 4 is always 4
//they can be grabbed very quickly b/c they live on the stack

//A common struct is DateTime

DateTime Today = DateTime.Today;
//Can also make our own DateTime
//using "new" we can Allocate space in memory for this date

DateTime birthday = new DateTime(1996,09,10);