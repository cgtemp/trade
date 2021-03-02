using System.Collections.Generic;
using TradeProcessor.App.Models;

namespace TradeProcessor.App.Interfaces
{
    internal interface ITradeDataReader
    {
        List<PriceRecord> BuildPriceModel();
    }
}
