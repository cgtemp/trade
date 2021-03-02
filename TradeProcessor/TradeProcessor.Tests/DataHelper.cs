using System.Collections.Generic;
using TradeProcessor.App.Models;

namespace TradeProcessor.Tests
{
    internal static class DataHelper
    {
        public static List<PriceRecord> GetTestDataWithHighValueAsFirstRecord()
        {
            return new List<PriceRecord>
            {
                new PriceRecord
                {
                    DayOfMonth = 1, Value = 9.99m

                },
                new PriceRecord
                {
                    DayOfMonth = 2, Value = 0.98m

                },
                new PriceRecord
                {
                    DayOfMonth = 3, Value = 2.34m

                },
                new PriceRecord
                {
                    DayOfMonth = 4, Value = 1.23m

                },
                new PriceRecord
                {
                    DayOfMonth = 5, Value = 8.68m

                },
                new PriceRecord
                {
                    DayOfMonth = 6, Value = 0.01m

                },
            };
        }

        public static List<PriceRecord> GetTestDataWithLowValueAsLastRecord()
        {
            return new List<PriceRecord>
            {
                new PriceRecord
                {
                    DayOfMonth = 1, Value = 1.11m

                },
                new PriceRecord
                {
                    DayOfMonth = 2, Value = 0.98m

                },
                new PriceRecord
                {
                    DayOfMonth = 3, Value = 2.34m

                },
                new PriceRecord
                {
                    DayOfMonth = 4, Value = 1.23m

                },
                new PriceRecord
                {
                    DayOfMonth = 5, Value = 8.68m

                },
                new PriceRecord
                {
                    DayOfMonth = 6, Value = 0.01m

                },
            };
        }

        public static List<PriceRecord> GetVanillaTestData()
        {
            return new List<PriceRecord>
            {
                new PriceRecord
                {
                    DayOfMonth = 1, Value = 1.11m

                },
                new PriceRecord
                {
                    DayOfMonth = 2, Value = 0.98m

                },
                new PriceRecord
                {
                    DayOfMonth = 3, Value = 2.34m

                },
                new PriceRecord
                {
                    DayOfMonth = 4, Value = 1.23m

                },
                new PriceRecord
                {
                    DayOfMonth = 5, Value = 8.68m

                },
            };
        }
    }
}
