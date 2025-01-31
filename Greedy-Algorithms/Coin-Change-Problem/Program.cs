using System;

namespace Problem_Solving
{
    /*         
              ------------Problem-------------
              
        Given a set of coin denominations and a total
        amount, find the minimum number of coins needed
        to make up that amount using the largest
        denominations possible.

     */

    public class Program
    {
        public static int minCoins(int[] denominations, int amount) // { 1, 5, 10, 20, 50, 100}
        {

            int coins = 0;
            int dLength = denominations.Length;
            for (var i = dLength - 1; i >= 0; --i) // i -> 5..0
            {
                while (amount >= denominations[i]) // max denomination : 100 
                {
                    amount -= denominations[i];
                    coins++;
                }
            }
            return coins;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Min Coins: {minCoins(new int[] { 1, 5, 10, 20, 50, 100 }, 786)}");
        }
    }
}
