using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            float rubToJpy = 2.28f, rubToUsd = 0.017f;
            float jpyToRub = 0.44f, jpyToUsd = 0.0073f;
            float usdToRub = 60.3f, usdToJpy = 137.56f;
            float balanceRub = 100f;
            float balanceJpy = 100f;
            float balanceUsd = 100f;
            string firstCurrency;
            string secondCurrency;
            float currencyToExchange;

            Console.WriteLine("Ваш баланс во всех валютах (RUB/JPY/USD) = 100");

            Console.Write("Выбор валюты для конвертации (RUB/JPY/USD):\t");
            firstCurrency = Console.ReadLine();
            Console.Write("В какую валюту конвертировать (RUB/JPY/USD):\t");
            secondCurrency = Console.ReadLine();
           
            switch (firstCurrency)
            {
                case "rub":
                    if (secondCurrency == "jpy")
                    {
                        Console.Write("RUB to JPY. Рублей к обмену:\t");
                        currencyToExchange = Convert.ToSingle(Console.ReadLine());
                        if (balanceRub >= currencyToExchange && currencyToExchange > 0f)
                        {
                            balanceRub -= currencyToExchange;
                            balanceJpy += currencyToExchange * rubToJpy;
                            Console.WriteLine("баланс в RUB: " + balanceRub);
                            Console.WriteLine("баланс в JPY: " + balanceJpy);
                        }
                        else
                        {
                            Console.WriteLine("Что-то многовато/маловато");
                        }
                    }
                    else if (secondCurrency == "usd")
                    {
                        Console.WriteLine("RUB to USD. Рублей к обмену:\t");
                        currencyToExchange = Convert.ToSingle(Console.ReadLine());
                        if (balanceRub >= currencyToExchange && currencyToExchange > 0f)
                        {
                            balanceRub -= currencyToExchange;
                            balanceUsd += currencyToExchange * rubToUsd;
                            Console.WriteLine("баланс в RUB: " + balanceRub);
                            Console.WriteLine("баланс в USD: " + balanceUsd);
                        }
                        else
                        {
                            Console.WriteLine("Что-то многовато/маловато");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Что-то пошло не так...");
                    }
                    break;

                case "jpy":
                    if (secondCurrency == "rub")
                    {
                        Console.WriteLine("JPY to RUB. Йен к обмену:\t");
                        currencyToExchange = Convert.ToSingle(Console.ReadLine());
                        if (balanceJpy >= currencyToExchange && currencyToExchange > 0f)
                        {
                            balanceJpy -= currencyToExchange;
                            balanceRub += currencyToExchange * jpyToRub;
                            Console.WriteLine("баланс в JPY: " + balanceJpy);
                            Console.WriteLine("баланс в RUB: " + balanceRub);
                        }
                        else
                        {
                            Console.WriteLine("Что-то многовато/маловато");
                        }
                    }
                    else if (secondCurrency == "usd")
                    {
                        Console.WriteLine("JPY to USD. Йен к обмену:\t");
                        currencyToExchange = Convert.ToSingle(Console.ReadLine());
                        if (balanceJpy >= currencyToExchange && currencyToExchange > 0f)
                        {
                            balanceJpy -= currencyToExchange;
                            balanceUsd += currencyToExchange * jpyToUsd;
                            Console.WriteLine("баланс в JPY: " + balanceJpy);
                            Console.WriteLine("баланс в USD: " + balanceUsd);
                        }
                        else
                        {
                            Console.WriteLine("Что-то многовато/маловато");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Что-то пошло не так...");
                    }
                    break;

                case "usd":
                    if (secondCurrency == "rub")
                    {
                        Console.WriteLine("USD to RUB. Долларов к обмену:\t");
                        currencyToExchange = Convert.ToSingle(Console.ReadLine());
                        if (balanceUsd >= currencyToExchange && currencyToExchange > 0f)
                        {
                            balanceUsd -= currencyToExchange;
                            balanceRub += currencyToExchange * usdToRub;
                            Console.WriteLine("баланс в USD: " + balanceUsd);
                            Console.WriteLine("баланс в RUB: " + balanceRub);
                        }
                        else
                        {
                            Console.WriteLine("Что-то многовато/маловато");
                        }
                    }
                    else if (secondCurrency == "jpy")
                    {
                        Console.WriteLine("USD to JPY. Долларов к обмену:\t");
                        currencyToExchange = Convert.ToSingle(Console.ReadLine());
                        if (balanceUsd >= currencyToExchange && currencyToExchange > 0f)
                        {
                            balanceUsd -= currencyToExchange;
                            balanceJpy += currencyToExchange * usdToJpy;
                            Console.WriteLine("баланс в USD: " + balanceUsd);
                            Console.WriteLine("баланс в Jpy: " + balanceJpy);
                        }
                        else
                        {
                            Console.WriteLine("Что-то многовато/маловато");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Что-то пошло не так...");
                    }
                    break;

                default:
                    Console.WriteLine("Что-то пошло не так...");
                    break;
            }
        }
    }
}
