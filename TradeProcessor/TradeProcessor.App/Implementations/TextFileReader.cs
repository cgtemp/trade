using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using TradeProcessor.App.Interfaces;
using TradeProcessor.App.Models;

namespace TradeProcessor.App.Implementations
{
    internal class TextFileReader : ITradeDataReader
    {
        private readonly string _dataFileName;
        private readonly IValidator _validator;

        public TextFileReader(string dataFileName, IValidator validator)
        {
            _dataFileName = dataFileName;
            _validator = validator;
        }

        public List<PriceRecord> BuildPriceModel()
        {
            var embeddedProvider = new EmbeddedFileProvider(Assembly.GetExecutingAssembly());

            using var stream = embeddedProvider.GetFileInfo(_dataFileName).CreateReadStream();
            using var streamReader = new StreamReader(stream);

            var contents = streamReader.ReadToEnd().Split(',');

            if (!_validator.ValidatePriceData(contents)) throw new InvalidDataException("Unable to parse price data.");

            return BuildModelFromFileContents(contents);
        }

        private List<PriceRecord> BuildModelFromFileContents(IReadOnlyList<string> data)
        {
            var list = new List<PriceRecord>();

            for (var index = 0; index < data.Count; index++)
            {
                var priceAsDecimal = Convert.ToDecimal(data[index]);
                var priceRecord = new PriceRecord { DayOfMonth = index + 1, Value = priceAsDecimal };
                list.Add(priceRecord);
            }

            return list;
        }
    }
}
