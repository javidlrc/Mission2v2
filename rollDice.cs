using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2v2
{
    internal class rollDice
    {
        private static Random dice = new Random();


        public static int[] RollingOfDice(int numRolls)
        {
            // This creates an array in which we will count the amount of times each number was rolled
            int[] rollCount = [];
            rollCount = new int[13];

            for (int i = 0; i < numRolls; i++)
            {
                // This is going to generate our random number for each one of our rolls
                int dice1 = dice.Next(1, 7);
                int dice2 = dice.Next(1, 7);
                int sumDice = dice1 + dice2;

                rollCount[sumDice]++;
            }

            return rollCount;

        }
        }
    }

