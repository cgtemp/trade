using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradeProcessor.App.Implementations;

namespace TradeProcessor.Tests
{
    [TestClass]
    public class FindBestTradeOperationTests
    {
        [TestMethod]
        public void GivenASetOfPriceData_ReturnTheExpectedBuyAndSellOutput()
        {
            var data = DataHelper.GetVanillaTestData();
            var sut = new FindBestTradeOperation();
            var result = sut.Run(data);

            Assert.IsTrue(result == "2(0.98),5(8.68)");
        }

        [TestMethod]
        public void GivenASetOfPriceDataWithLowValueAsLastRecord_ReturnTheExpectedBuyAndSellOutput()
        {
            var data = DataHelper.GetTestDataWithLowValueAsLastRecord();
            var sut = new FindBestTradeOperation();
            var result = sut.Run(data);

            Assert.IsTrue(result == "2(0.98),5(8.68)");
        }

        [TestMethod]
        public void GivenASetOfPriceDataWithHighValueAsFirstRecord_ReturnTheExpectedBuyAndSellOutput()
        {
            var data = DataHelper.GetTestDataWithLowValueAsLastRecord();
            var sut = new FindBestTradeOperation();
            var result = sut.Run(data);

            Assert.IsTrue(result == "2(0.98),5(8.68)");
        }
    }
}
