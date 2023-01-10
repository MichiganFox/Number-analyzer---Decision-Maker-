// User Input
using System;

bool numdesig = true;
do

{
    Console.WriteLine("What is  your name?");
    string user_name = Console.ReadLine();
    Console.WriteLine("Nice to meet you " + (user_name));
    Console.WriteLine("Please enter a number between 1 and 100");
    int user_number = int.Parse(Console.ReadLine());

    // Calculations 
    if (user_number < 1 || user_number > 100)
    {
        Console.WriteLine("Please enter a number between 1 and 100!");
    }

        else if (user_number % 2 != 0 && user_number < 60)
        {
            Console.WriteLine(user_name + " , " + user_number + " is odd and less than 60");
        }
        else if (user_number % 2 == 0 && user_number >= 2 && user_number <= 24)
        {
            Console.WriteLine(user_name + " , " + user_number + " is even and less than 25");
        }
        else if (user_number % 2 == 0 && user_number >= 26 && user_number <= 60)
        {
            Console.WriteLine(user_name + " , " + user_number + " is even and between 26 and 60");
        }
        else if (user_number % 2 == 0 && user_number > 60)
        {
        Console.WriteLine(user_name + " , " + user_number + " is even and more than 60");
        }
        else if (user_number % 2 != 0 && user_number > 60)
        {
            Console.WriteLine(user_name + " , " + user_number + " is odd and more than 60");
        }
    
    Console.WriteLine(user_name + " would you like to do this again?  Yes or No");
    string user_answer = Console.ReadLine();

    if (user_answer == "no" || user_answer == "n")
    {
        break;
    }

}
while (numdesig = true);
