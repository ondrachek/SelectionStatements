using System;

namespace SelectionStatements;

internal class Program
{
    static void Main(string[] args)
    {
        int favoriteNumber = 19;

        Console.WriteLine("Guess the favorite number. hint: below 20");
        int userGuess = int.Parse(Console.ReadLine());

        if (userGuess < favoriteNumber) 
        {
            Console.WriteLine("ehhhh wrong, too low!!");
        
        
        }
        else if (userGuess > favoriteNumber)
        {
            Console.WriteLine("Who guess's 20, wrong answer");
        }
        
        else if (userGuess == favoriteNumber)
        {
            Console.WriteLine("Winner Winner Chicken Dinner, you are correct");

        

        }
        else
        {
            Console.WriteLine("nevermind");

        }

        string subject = "C#";

        Console.WriteLine("What is your favorite subject?");
        string userSubject = Console.ReadLine();

        switch (userSubject) 
        {
            case "C#";
                Console.WriteLine("congrats! you made it!");
                break;
            case "gym";
                Console.WriteLine("Rock on! mine too!");
                break;
            case "Social Studies";
                Console.WriteLine("Come on! Really!!? no its not.");
                break;
            case "art";
                Console.WriteLine("I guess everybody is different..... ");
                break;
            case "math";
                Console.WriteLine("I like math too buddy");
                break;
                default:
                Console.WriteLine("Have fun with that");



        
        
        
        
        }



    }
}
