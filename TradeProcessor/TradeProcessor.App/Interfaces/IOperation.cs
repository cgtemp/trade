using System.Collections.Generic;
using TradeProcessor.App.Models;

namespace TradeProcessor.App.Interfaces
{
    internal interface IOperation
    {
        string Run(List<PriceRecord> tradeData);
    }
}
