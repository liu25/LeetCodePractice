using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Problem122
    {
        public int MaxProfit(int[] prices)
        {
            //
            int buyPrice = -1;
            int profit = 0;
        

            for (int i = 0; i < prices.Length; i++)
            {
                if (ShouldBuy(prices, i, buyPrice))
                {
                    buyPrice = prices[i];
                }
                else if (ShouldSell(prices, i, buyPrice))
                {
                    profit += prices[i] - buyPrice;
                    buyPrice = -1;
                }
            }

            return profit;
        }        

        private bool ShouldBuy(int[] prices, int i, int buyPrice)
        {
            if (buyPrice >= 0)
                return false;

            if (i < prices.Length - 1 && prices[i + 1] > prices[i])
                return true;

            return false;
        }

        private bool ShouldSell(int[] prices, int i, int buyPrice)
        {
            if (buyPrice < 0)
                return false;

            if (i == prices.Length - 1)
                return true;

            if (i < prices.Length - 1 && prices[i + 1] < prices[i])
                return true;

            return false;
        }
    }
}
