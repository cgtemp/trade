using System.Linq;
using TradeProcessor.App.Interfaces;

namespace TradeProcessor.App.Implementations
{
    internal class Validator : IValidator
    {
        public bool ValidatePriceData(string[] data)
        {
            // can add more validations here if needed
            return ValidatePricesAreDecimalType(data);
        }

        private bool ValidatePricesAreDecimalType(string[] data)
        {
            return data.All(priceData => decimal.TryParse(priceData, out _));
        }
    }
}
