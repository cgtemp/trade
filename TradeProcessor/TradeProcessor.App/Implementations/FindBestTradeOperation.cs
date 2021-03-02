using System.Collections.Generic;
using System.Linq;
using TradeProcessor.App.Interfaces;
using TradeProcessor.App.Models;

namespace TradeProcessor.App.Implementations
{
    internal class FindBestTradeOperation : IOperation
    {
        public string Run(List<PriceRecord> tradeData)
        {
            decimal highestGap = 0;
            var buyPrice = new PriceRecord();
            var sellPrice = new PriceRecord();

            foreach (var openingPriceRecord in tradeData)
            {
                // sell candidates should be prices after openingPriceRecord.DayOfMonth, and greater than openingPriceRecord.Value
                var sellCandidates = tradeData
                    .Where(x => x.DayOfMonth > openingPriceRecord.DayOfMonth)
                    .Where(x => x.Value > openingPriceRecord.Value);

                foreach (var sellCandidate in sellCandidates)
                {
                    var gap = sellCandidate.Value - openingPriceRecord.Value;
                    if (gap > highestGap)
                    {
                        buyPrice = openingPriceRecord;
                        sellPrice = sellCandidate;
                        highestGap = gap;
                    }
                }
            }

            return $"{buyPrice.DayOfMonth}({buyPrice.Value}),{sellPrice.DayOfMonth}({sellPrice.Value})"; 
        }
    }
}
