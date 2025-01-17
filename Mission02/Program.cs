// See https://aka.ms/new-console-template for more information
// Brandon Fromm
// Section 003
// Group 9
namespace Mission2;

class Program
{
    public static void Main(string[] args)
    {
        Dice d = new Dice();
        
        // display welcome message and asks for number of rolls
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine();
        Console.WriteLine("How many dice rolls would you like to simulate?");
        
        // gets number of rolls from input and creates an array for the returned array of RollDice class
        int numRolls = Convert.ToInt32(Console.ReadLine());
        int[] rollsArray = d.RollDice(numRolls);
        
        // more messages
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numRolls}.");
        Console.WriteLine();
        
        // iterates through each possible roll result
        for (int i = 2; i <= 12; i++)
        {
            // calculates the percent of each roll number and displays the number and the percent in asterisks
            int dicePercentage = (rollsArray[i] * 100) / numRolls;
            
            Console.Write($"{i}: ");
            Console.WriteLine(new string('*', dicePercentage));
            
        }
        // prints goodbye message
        Console.WriteLine();
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye");
    }
}