using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollSimulator
{
    internal class diceRole
    {
        // Random number generator for dice rolls.
        Random rnd = new Random();

        // Method to simulate dice rolls.
        public int[] diceRoleSimulation(int num)
        {
            // Initialize variables for the two dice and the total of their roll.
            int dice1 = 0;
            int dice2 = 0;
            int rollTotal = 0;

            // Create an array to store the count of each possible roll total (2-12).
            int[] rolls = new int[13]; 

            // Loop through the number of rolls specified.
            for (int roll = 0; roll < num; roll++)
            {
                // Roll two dice.
                dice1 = rnd.Next(1, 7);
                dice2 = rnd.Next(1, 7);

                // Sum the values of the two dice.
                rollTotal = dice1 + dice2;

                // Increment the count for this roll total.
                rolls[rollTotal]++;
            }

            // Return the array containing the counts of each roll total.
            return rolls;
        }
    }
}
