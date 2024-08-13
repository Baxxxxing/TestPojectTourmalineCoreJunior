using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPojectTourmalineCoreJunior
{
    public class ChangeCalculator
    {
        static void Main(string[] args){}

        public static string GetChange(int[] nominal, int[] countNominal, int change)
        {
            int[] remainingCoins = (int[])countNominal.Clone();
            List<(int, int)> result = new List<(int, int)>();

            for (int i = 0; i < nominal.Length; i++)
            {
                int coinValue = nominal[i];
                int maxCoins = Math.Min(change / coinValue, remainingCoins[i]);
                if (maxCoins > 0)
                {
                    result.Add((coinValue, maxCoins));
                    change -= maxCoins * coinValue;
                    remainingCoins[i] -= maxCoins;
                }
            }
            if (change == 0)
            {
                string resultMessage = "Для сдачи используйте следующие монеты:";
                foreach (var (coinValue, quantity) in result)
                {
                    resultMessage += $" {coinValue}р x {quantity}";
                }
                return resultMessage;
            }
            else
            {
                return "Невозможно вернуть сдачу, используйте кредитную карту.";
            }
        }
    }
}
