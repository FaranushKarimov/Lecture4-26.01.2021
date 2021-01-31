using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class Converter
    {
        public double amount { get; set; }
        public double usd { get; set; }
        public double eur { get; set; }
        public double rub { get; set; }
        public double tjs { get; set; }
        public Converter(double Usd = 10.22, double Eur = 11.04, double Rub = 0.13)
        {
            usd = Usd;
            eur = Eur;
            rub = Rub;
        }
        public void toTjs(double converter, double sum)
        {
            System.Console.WriteLine($"{sum} = {sum * converter} TJS");
        }
        public void toUsd(double converter, double sum)
        {
            System.Console.WriteLine($"{sum} TJS = {sum / converter} USD");
        }
        public void toEur(double converter, double sum)
        {
            System.Console.WriteLine($"{sum} = {sum / converter} EUR");
        }
        public void toRub(double converter, double sum)
        {
            System.Console.WriteLine($"{sum} = {sum / converter} RUB");
        }
    }
}
