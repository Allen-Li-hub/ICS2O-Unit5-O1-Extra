// Created by: Allen li
// Created on: Nov 2022
//

using System;

class Program
{
    public static void Main(string[] args)
    {
        int userNumber;
        int randomNumber;

        Console.WriteLine("Can you guess the random number from 1-6?");
        Console.WriteLine("");

        Console.Write("Enter random value from 1-6: ");
        Console.WriteLine("");
        userNumber = Convert.ToInt16(Console.ReadLine());

        Random rnd = new Random();
        randomNumber = rnd.Next(1, 6);

        Console.WriteLine("");
        if (userNumber == randomNumber)
        {
            Console.WriteLine("The answer was: " + randomNumber + ". You got it right!");
        }

        if (userNumber != randomNumber)
        {
            Console.WriteLine("The answer was: " + randomNumber + ". Your answer was wrong. Please try again!");
        }

        Console.WriteLine("\nDone.");
    }
}