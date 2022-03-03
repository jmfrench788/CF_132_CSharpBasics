//Syntax
//value being evaluated, often a variable
// the switch keyword
// a body that contains cases called "expression arms", denoted by {}
// The comma separated by "expression arms" are made up of 3 parts:
    //1. the expected value, called a "pattern"
    //2. A "fat arrow" denoted as '=>'
    //3. The actual expression or value to be returned
//a discard pattern, denoted with an '_', which is the default

System.Console.WriteLine("Please enter your name");
string username = Console.ReadLine();
string greeting = username switch
{
    "Pete" => "Hello Pete",
    _ =>"Who are you?" //returned for every other possible value not above

};
System.Console.WriteLine(greeting);



System.Console.WriteLine("How were you feeling yesterday from 1-5?");
int yesterday = int.Parse(Console.ReadLine());

string response = yesterday switch
{

    1=>"Hope today is a better day.",
    2=>"Sorry to hear that.",
    3=>"Hope things get better this week.",
    4=>"Good stuff.",
    5=>"That is great to hear.",
    _ =>"Invalid"
};

System.Console.WriteLine(response);