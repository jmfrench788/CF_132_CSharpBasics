//If statement when conditions are not met, do something else



bool raining = false;

if (!raining)
{
    System.Console.WriteLine("Not raining.");
}
    else
    {
        System.Console.WriteLine("It is raining.");
    }

bool outside = true;

if (outside)
{
    System.Console.WriteLine("Dress for the weather.");
}
    else if(outside && raining)
    {
        System.Console.WriteLine("Dress for the weather and bring an umbrella.");
    }
    else
    {
        System.Console.WriteLine("Wear whatever you want.");
    }



int mood;

System.Console.WriteLine("How are you on a scale of 1-5?");

mood = int.Parse(Console.ReadLine());

if(mood == 1)
{
    System.Console.WriteLine("Hope your day gets better.");
}

    else if(mood == 2)
    {
        System.Console.WriteLine("Sorry to hear that.");
    }

    else if(mood ==3)
    {
        System.Console.WriteLine("I hope things improve.");
    }

    else if(mood == 4)
    { 
        System.Console.WriteLine("Good stuff");
    }

    else if(mood == 5)
    {
        System.Console.WriteLine("That is great to hear.");
    }

    else
    {
        System.Console.WriteLine("Invalid. Please enter a number from 1 to 5.");
    }