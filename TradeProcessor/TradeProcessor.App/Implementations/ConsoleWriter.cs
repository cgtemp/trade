using System;
using TradeProcessor.App.Interfaces;

namespace TradeProcessor.App.Implementations
{
    internal class ConsoleWriter : IPrinter
    {
        public void Print(string lineToPrint)
        {
            Console.WriteLine(lineToPrint);
        }
    }
}
