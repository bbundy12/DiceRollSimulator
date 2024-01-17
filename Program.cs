using DiceRollSimulator;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create an instance of the diceRole class to simulate dice rolls.
        diceRole dr = new diceRole();

        // Greet the user and ask for the number of dice rolls to simulate.
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n\n" +
            "How many dice rolls would you like to simulate?");

        int num = int.Parse(System.Console.ReadLine());

        // Store the results in an array from the diceRoleSimulations method
        int[] rolls = dr.diceRoleSimulation(num);

        // Display the header for the simulation results.
        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\n" +
                                "Each \"*\" represents 1 % of the total number of rolls.\n" +
                                "Total number of rolls = " + num + ".\n");

        // Initialize an empty string for the output.
        string output = "";

        // Loop through the possible dice numbers (2 to 12).
        for (int diceNum = 2; diceNum < 13; diceNum++)
        {
            // Calculate the percentage of each dice number.
            decimal percentage = (decimal)rolls[diceNum] / num * 100;
            int roundedPercentage = (int)Math.Round(percentage);

            // Count the total rolls for this dice number.
            int totalRolls = rolls[diceNum];

            // Prepare the line for this dice number in the output.
            output += diceNum + ": ";

            // Add asterisks representing the percentage.
            for (int asterisk = 0; asterisk < percentage; asterisk++)
            {
                output += '*';
            }
            output += "\n";
        }

        // Display the final output and a closing message.
        System.Console.Write(output + "\nThank you for using the dice throwing simulator. Goodbye!\n");
    }
}
