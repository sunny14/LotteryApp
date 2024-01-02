

namespace ArraysApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int ticketSize = 5;
            int[] ticket = new int[ticketSize];

            Console.Write("Fill the lottery!\nEnter "+ticketSize+" numbers:\n");
 
            //לולאה לקליטת כל ערכי המערך
            for (int i = 0; i < ticket.Length; i++)
            {
                ticket[i] = int.Parse(Console.ReadLine()); // שיטה שקולטת מספר שלם מהמשתמש
            }

            Console.Write("Your lottery ticket is:\n");
            for (int i = 0; i < ticket.Length; i++)
            {
                Console.Write( ticket[i]+" ");
            }

            Console.Write("Lottery wining numbers is:\n");
            int[] winning = new int[ticketSize];
            for (int i = 0; i < winning.Length; i++)
            {
                winning[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Lets check your lottery ticket! ");

            int winCount = 0;
            for (int i=0; i< winning.Length; i++)
            {
                int win = winning[i];
                int num = ticket[i];
                if (win == num)
                {
                    winCount++;
                }
            }

            if(winCount >= 5)
            {
                Console.WriteLine("You guessed "+winCount+" numbers! You win the BIG PRICE!!!");
            }
            else if (winCount <5 && winCount>0)
            {
                Console.WriteLine("You guessed \"+winCount+\" numbers. You win the small and cute price!!!");
            }
            else
            {
                Console.WriteLine("You guessed no numbers. No price for you, you should try better!");
            }
        }
    }
}
