using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradeProcessor.App;
using TradeProcessor.App.Implementations;

namespace TradeProcessor.Tests
{
    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        public void GivenASpecificDataSet_ControllerShouldPrintOutCorrectResult()
        {
            var operation = new FindBestTradeOperation();
            var printer = new FakeObjects.FakePrinter();
            var dataReader = new FakeObjects.DataReader();

            var controller = new Controller(dataReader, printer, operation);
            controller.ProcessOperation();

            Assert.IsTrue(printer.PrinterOutput == "2(0.98),5(8.68)");
        }
    }
}
