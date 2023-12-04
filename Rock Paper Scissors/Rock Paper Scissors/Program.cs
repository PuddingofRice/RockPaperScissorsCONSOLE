using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            /* the player choice variable */
            string pChoice;

            /* Computer Choice A.K.A random number generator */
            Random rnd = new Random();
            int cChoice = rnd.Next(1, 4);

            /* starting text */
            Console.WriteLine("Rock.! Paper! Scissors! Shoot!");
            pChoice = Console.ReadLine();

            /* game result code */
            if (pChoice == "Rock" && cChoice == 1)
            {
                /* Result if both pick Rock */
                Console.WriteLine("Thats a draw!");
            } else if (pChoice == "Rock" && cChoice == 2)
            {
                /* Result if Rock Looses */
                Console.WriteLine("Paper beats rock my friend! I win!");
            } else if (pChoice == "Rock" && cChoice == 3)
            {
                /* Result if Rock Wins */
                Console.WriteLine("Rock beats scissors. You win.");
            } else if (pChoice == "Paper" && cChoice == 1)
            {
                /* Result if paper wins */
                Console.WriteLine("Paper beats rock. You win.");
            } else if (pChoice == "Paper" && cChoice == 2)
            {
                /* Result if both pick paper */
                Console.WriteLine("Thats a draw!");
            } else if (pChoice == "Paper" && cChoice == 3)
            {
                /* Result if paper looses */
                Console.WriteLine("Scissors beats paper my friend! I win!");
            } else if (pChoice == "Scissors" && cChoice == 1)
            {
                /* Result if scissors looses */
                Console.WriteLine("Rock beats scissors my friend! I win!");
            } else if (pChoice == "Scissors" && cChoice == 2)
            {
                /* Result if scissors win */
                Console.WriteLine("Scissors beat paper. You win.");
            } else if (pChoice == "Scissors" && cChoice == 3)
            {
                /* Result if both pick scissors */
                Console.WriteLine("Thats a draw!");
            } else
            {
                /* Result if user enter something other than Rock, Paper or Scissors */
                Console.WriteLine("Mate! We playing Rock Paper Scissors!");
            }
        }
    }
}
