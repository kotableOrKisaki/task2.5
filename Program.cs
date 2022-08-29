using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CaseRub = "rub";
            const string CaseJpy = "jpy";
            const string CaseUsd = "usd";
            float rubToJpy = 2.28f;
            float rubToUsd = 0.017f;
            float jpyToRub = 0.44f;
            float jpyToUsd = 0.0073f;
            float usdToRub = 60.3f;
            float usdToJpy = 137.56f;
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
                case CaseRub:

                    if (secondCurrency == CaseJpy)
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
                    else if (secondCurrency == CaseUsd)
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

                case CaseJpy:

                    if (secondCurrency == CaseRub)
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
                    else if (secondCurrency == CaseUsd)
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

                case CaseUsd:

                    if (secondCurrency == CaseRub)
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
                    else if (secondCurrency == CaseJpy)
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
