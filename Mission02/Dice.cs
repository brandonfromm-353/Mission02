namespace Mission2;

public class Dice
{
    public int[] RollDice(int numRolls)
    {
        // gets random class and creates an array for the dice rolls
        Random rnd = new Random();
        int[] diceArray = new int[13];
        
        // gets the result of dice rolls for the number of rolls the user inputs
        for (int i = 0; i < numRolls; i++)
        {
            // get dice rolls
            int diceOne = rnd.Next(1, 7);
            int diceTwo = rnd.Next(1, 7);
            
            int diceTotal = diceOne + diceTwo;
            
            // add rolls to the array for the given dice roll result
            diceArray[diceTotal]++;
        }
        return diceArray;
    }
}