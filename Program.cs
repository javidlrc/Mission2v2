using System;
using Mission2v2;

internal class Program
{
    private static void Main(string[] args)
    {
        int numRolls = 0;

        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");

        numRolls = int.Parse(Console.ReadLine());

        rollDice rd = new rollDice();

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = {numRolls}.");

        rollDice rollDice = new rollDice();
        int[] summary = rollDice.RollingOfDice(numRolls);

        for (int i = 2; i <= 12; i++) 
        { 
            int percentage = summary[i] * 100 / numRolls;
            Console.WriteLine($"{i}: {new string('*', percentage)} ({percentage}%)");
        }


        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");


    }
}
