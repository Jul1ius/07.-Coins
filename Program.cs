using System;

namespace _07._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());

            int coins = 0;

            
            int stotinki = (int)(value * 100); 

            int curStotinkiCoin = 200;

            while (curStotinkiCoin != 0)
            {
                coins += stotinki / curStotinkiCoin;
                stotinki = stotinki % curStotinkiCoin;

                switch (curStotinkiCoin)
                {
                    case 200: curStotinkiCoin = 100; break;
                    case 100: curStotinkiCoin = 50; break;
                    case 50: curStotinkiCoin = 20; break;
                    case 20: curStotinkiCoin = 10; break;
                    case 10: curStotinkiCoin = 5; break;
                    case 5: curStotinkiCoin = 2; break;
                    case 2: curStotinkiCoin = 1; break;
                    case 1: curStotinkiCoin = 0; break; 
                }
            }

            Console.WriteLine(coins);
        }

        static void Main_double(string[] args)
        {
            double value = double.Parse(Console.ReadLine());

            int coins = 0;

            double curStotinkiCoinValue = 0.01; 

            while (value != 0)
            {
                if (value >= curStotinkiCoinValue)
                {
                    coins++; 
                    value = Math.Round(value - curStotinkiCoinValue, 2); 
                }
                else
                    
                    switch (curStotinkiCoinValue)
                    {
                        case 2.00: curStotinkiCoinValue = 1.00; break;
                        case 1.00: curStotinkiCoinValue = 0.50; break;
                        case 0.50: curStotinkiCoinValue = 0.20; break;
                        case 0.20: curStotinkiCoinValue = 0.10; break;
                        case 0.10: curStotinkiCoinValue = 0.05; break;
                        case 0.05: curStotinkiCoinValue = 0.02; break;
                        case 0.02: curStotinkiCoinValue = 0.01; break;
                        case 0.01: curStotinkiCoinValue = 0; break; 
                    }
            }

            Console.WriteLine(coins);
        }
    }
}
