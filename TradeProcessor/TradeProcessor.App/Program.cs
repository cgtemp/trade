using System;
using TradeProcessor.App.Implementations;

namespace TradeProcessor.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleFile = "ChallengeSampleDataSet1.txt";

            Console.WriteLine("About to run Trade Processing...");

            var dataReader= new TextFileReader(sampleFile, new Validator());
            var printer = new ConsoleWriter();
            var operation = new FindBestTradeOperation();

            var controller = new Controller(dataReader, printer, operation);
            controller.ProcessOperation();

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}
