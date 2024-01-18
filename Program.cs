using System;
using Mission2v2;

internal class Program
{
    private static void Main(string[] args)
    {
        int numRolls = 0;

        // starts the text of the program
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");

        // recieves user input and assigns it to numRolls variable
        numRolls = int.Parse(Console.ReadLine());


        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = {numRolls}.");

        // assigns a new object to rollDice variable and assigns the array from the rollingofdice function to the summary array
        rollDice rollDice = new rollDice();
        int[] summary = rollDice.RollingOfDice(numRolls);

        // loop to priint out the results and creates histogram
        for (int i = 2; i <= 12; i++) 
        { 
            // goes over every position in the array and converts it into a percentage
            int percentage = summary[i] * 100 / numRolls;
            Console.WriteLine($"{i}: {new string('*', percentage)} ({percentage}%)");
        }


        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");


    }
}
