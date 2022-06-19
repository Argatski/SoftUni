using System;

namespace StockMarket
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Initialize Stock
            Stock ibmStock = new Stock("IBM", "Arvind Krishna", 138.50m, 5000);
            
            //Print a stock
            Console.WriteLine(ibmStock.ToString());

            // Initialize Investor
            Investor investor = new Investor("Peter Lynch", "p.lynch@gmail.com", 2000m, "Fidelity");

            //Buy a stock
            investor.BuyStock(ibmStock);

            //Sell a stock
            Console.WriteLine(investor.SellStock("IBM", 150.00m));
            Console.WriteLine(investor.SellStock("IBN", 180.00m));//Does exist.

            //Add stocks
            Stock teslaStock = new Stock("Tesla", "Elon Musk", 743.17m, 6520);
            Stock amazonStock = new Stock("Amazon", "Jeff Bezos", 3457.17m, 8500);
            Stock twitterStock = new Stock("Twitter", "Jack Dorsey", 59.66m, 11200);
            Stock blizzarStock = new Stock("Activision Blizzard", "Bobby Kotick", 78.53m, 5520);

            Console.WriteLine("....................");

            //Buy more stocks
            investor.BuyStock(teslaStock);
            investor.BuyStock(amazonStock);
            investor.BuyStock(twitterStock);
            investor.BuyStock(blizzarStock);


            //Find stock
            //Console.WriteLine(investor.FindStock("Tesla").ToString());
            //Console.WriteLine(investor.FindStock("Tesla").ToString());

            //Find biggest company
            Console.WriteLine(investor.FindBiggestCompany());

            //Print investor information
            Console.WriteLine(investor.InvestorInformation());
        }
    }
}
