

namespace LotteryApp
{
    /* EXAMPLE OF USAGE:
     * Fill the lottery!
        Enter 5 numbers:
        5
        6
        7
        8
        9
        Your lottery ticket is:
        5 6 7 8 9 Lottery wining numbers is:
        1
        2
        3
        4
        5
        Lets check your lottery ticket!
        You guessed no numbers. No price for you, you should try better!
     * 
     */


    public class Program
    {
        private static void Main(string[] args)
        {
            //size will be always 5 or more
            int size = 5;

            //get ticket
            int[] ticket = new int[size];

            //fill ticket
            Console.WriteLine("Enter "+ticket.Length+" numbers:");
            for(int i=0; i < ticket.Length; i++)
            {
                ticket[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Here is your ticket:");
            for (int i = 0; i < ticket.Length; i++)
            {
                Console.Write(ticket[i]+" ");
            }


            //get winning numbers
            int[] winningNumbers = new int[size];
            Console.WriteLine("\nEnter " + winningNumbers.Length + " WINNING numbers:");
            for (int i = 0; i < winningNumbers.Length; i++)
            {
                winningNumbers[i] = int.Parse(Console.ReadLine());
            }

            //compare ticket to winning numbers
            //count matches
            int matches = 0;
            for(int i=0; i<ticket.Length; i++)
            {
                int mynumber = ticket[i];
                int winningNumber = winningNumbers[i];

                if (mynumber == winningNumber)
                {
                    matches++;
                }
            }

            //get price accourding to your matches:
            // 5 matches - you get a big price
            // 1-4 matches - you get a small price
            // no matches - no price
            if (matches >= 5)
            {
                Console.WriteLine("You win the BIG PRICE!!!");
            }
            else if (matches == 0)
            {
                Console.WriteLine("No price for you!!");
            }
            else 
            {
                Console.WriteLine("You win the small price");
            }
        }
    }
}
