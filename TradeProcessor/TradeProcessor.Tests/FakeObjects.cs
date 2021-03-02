using System.Collections.Generic;
using TradeProcessor.App.Interfaces;
using TradeProcessor.App.Models;

namespace TradeProcessor.Tests
{
    internal class FakeObjects
    {
        internal class FakePrinter : IPrinter
        {
            public string PrinterOutput { get; set; }

            public void Print(string lineToPrint)
            {
                PrinterOutput = lineToPrint;
            }
        }

        internal class DataReader : ITradeDataReader
        {
            public List<PriceRecord> BuildPriceModel()
            {
                return DataHelper.GetVanillaTestData();
            }
        }
    }
}
