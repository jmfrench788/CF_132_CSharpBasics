//Ternary Expressions
//Composed of 3 parts

//Syntax
        //1          //2                   //3
//boolear expression ? expression if true : expression if false

//1. boolean expression to be evaluated
//2. separates boolean and the true result
//3. separates the true and false results

//EX
System.Console.WriteLine("Enter your age.");
int age = int.Parse(Console.ReadLine());
string output = (age >= 18)? "You can vote." : "You are too young to vote.";

System.Console.WriteLine(output);