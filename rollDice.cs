using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2v2
{
    //new class for rollDice function
    internal class rollDice
    {
        //grabs the random object to create random objects and stores it in the "dice" variable
        private static Random dice = new Random();

        //rolling dice function
        public static int[] RollingOfDice(int numRolls)
        {
            // This creates an array in which we will count the amount of times each number was rolled
            int[] rollCount = [];
            // this assigns 12 spots to the array
            rollCount = new int[13];

            // loop so that it generates the total amount of scores (based on # of rolls) and it stores it in the array
            for (int i = 0; i < numRolls; i++)
            {
                // This is going to generate our random number for each one of our rolls
                int dice1 = dice.Next(1, 7);
                int dice2 = dice.Next(1, 7);
                int sumDice = dice1 + dice2;

                //this is so that in every score (aka the position) it adds a point to it
                rollCount[sumDice]++;
            }

            // returns the array
            return rollCount;

        }
        }
    }

