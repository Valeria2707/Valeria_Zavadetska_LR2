
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    class Currency
    {
        /*private string name ;
        private double amount;
        private double price;*/
        private double x;

        public double X
        {
            get => this.X;

        }
     /*   public string Name
        {
            get => this.name;

        }
        public double Amount
        {
            get => this.amount;

        }
        public double Price
        {
            get => this.price;

        }*/
        public string currencyFromName
        {
            get;
        }

        public double priceFrom
        {
            get;
        }
        public string currencyToName
        {
            get;
        }
        public double priceTo
        {
            get;
        }
        public Currency(string currencyFromName, string currencyToName, double priceFrom, double priceTo)
        {
           
            this.currencyFromName = currencyFromName;
            this.currencyToName = currencyToName;
            this.priceFrom = priceFrom;
            this.priceTo = priceTo ;
            
       
        }

        public double currentcurrency()
        {
            Console.Write( "Встановіть поточний курс валюти: ");
            return this.x;
        }
    }

    class CurrencyConvert
    {
        public List<Currency> currencies = new List<Currency>();

        public CurrencyConvert(List<Currency> currencies)
        {
            this.currencies = currencies;
        }
        public double sell(string curryncyFrom, string currencyTo, double amount)
        {
            var index = currencies.FindIndex(c => c.currencyFromName == curryncyFrom && c.currencyToName == currencyTo);
            if (index != -1)
            {
                var curr = currencies[index];
                var result = amount * curr.priceFrom;
                return result;
            } 
            else
            {
                index = currencies.FindIndex(c => c.currencyFromName == currencyTo && c.currencyToName == curryncyFrom);
                if (index != -1)
                {
                    var curr = currencies[index];
                    var result = amount * curr.priceTo;
                    return result;
                }
            }

            return -1;
        }

        public void sortByCurrent()
        {
            for (int barrier = currencies.Count - 1; barrier > -1; barrier--)
            {
                for (int index = 0; index < barrier; index++)
                {
                    if (currencies[index].priceFrom > currencies[index + 1].priceFrom)
                    {
                        (currencies[index], currencies[index + 1]) = (currencies[index + 1], currencies[index]);
                    }
                }
            }
        }

        public void getParcels()
        {
            for (int index = 0; index < currencies.Count; index++)
            {
               
                
                Console.Write(currencies[index].currencyToName.ToString() +"  ");
                Console.Write(currencies[index].currencyFromName.ToString() + " ");
                Console.Write(currencies[index].priceFrom.ToString() + "  ");
                Console.Write(currencies[index].priceTo.ToString() + " \n ");

            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Currency currency1 = new Currency("uah", "usd", 0.034, 29.46);
            Currency currency2 = new Currency("pln", "usd", 0.24, 4.25);
            Currency currency3 = new Currency("uah", "czk", 0.76, 1.32);
            Currency currency4 = new Currency("gbr", "sek", 12.27, 0.082);
            Currency currency5 = new Currency("eur", "try", 16.02, 0.06);

            CurrencyConvert currencyConvert = new CurrencyConvert(new List<Currency> { currency1, currency2, currency3, currency4, currency5 });

            currencyConvert.sortByCurrent();
            currencyConvert.getParcels();
            var result = currencyConvert.sell("usd", "uah", 10);
            var result1 = currencyConvert.sell("pln", "usd", 200);
            var result2 = currencyConvert.sell("czk", "uah", 50);
            var result3 = currencyConvert.sell("gbr", "sek", 100);
            var result4 = currencyConvert.sell("try", "eur", 1000);
            var result5 = currencyConvert.sell("uah", "usd", 5000);
            var result6 = currencyConvert.sell("usd", "pln", 700);
            var result7 = currencyConvert.sell("uah", "czk", 300);
            var result8 = currencyConvert.sell("sek", "gbr", 5);
            var result9 = currencyConvert.sell("eur", "try", 40);


            Console.WriteLine("Конвертер валюти з долара в гривнi ");
            Console.WriteLine(result);
            Console.WriteLine("Конвертер валюти з злотих в долари");
            Console.WriteLine(result1);
            Console.WriteLine("Конвертер валюти з гривні в чеськi крони");
            Console.WriteLine(result2);
            Console.WriteLine("Конвертер валюти з фунта в шведськi крони");
            Console.WriteLine(result3);
            Console.WriteLine("Конвертер валюти з лiри в євро");
            Console.WriteLine(result4);
            Console.WriteLine("Конвертер валюти з гривнi в долари");
            Console.WriteLine(result5);
            Console.WriteLine("Конвертер валюти з долара в злоті");
            Console.WriteLine(result6);
            Console.WriteLine("Конвертер валюти з чеської крони в гривні");
            Console.WriteLine(result7);
            Console.WriteLine("Конвертер валюти з щведської крони в фунти");
            Console.WriteLine(result8);
            Console.WriteLine("Конвертер валюти з євро в ліри");
            Console.WriteLine(result9);



        }
    }
}


