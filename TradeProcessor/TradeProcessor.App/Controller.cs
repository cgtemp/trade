using TradeProcessor.App.Interfaces;

namespace TradeProcessor.App
{
    internal class Controller
    {
        private readonly ITradeDataReader _dataReader;
        private readonly IPrinter _printer;
        private readonly IOperation _operation;

        public Controller(ITradeDataReader dataReader, IPrinter printer, IOperation operation)
        {
            _dataReader = dataReader;
            _printer = printer;
            _operation = operation;
        }

        public void ProcessOperation()
        {
            var tradeData = _dataReader.BuildPriceModel();
            var result = _operation.Run(tradeData);
            _printer.Print(result);
        }
    }
}
