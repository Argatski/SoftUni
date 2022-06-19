using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {

        private List<Stock> portfolio;


        //Properties
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }



        //Constructor
        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;

            this.portfolio = new List<Stock>();
        }

        /// <summary>
        /// Getter Count - returns the count of the currently owned stocks.
        /// </summary>
        public int Count
        {
            get { return portfolio.Count; }
            private set { Count = value; }
        }

        /// <summary>
        ///Method void BuyStock(Stock stock) – add a single stock of the given company if the stock’s market capitalization is bigger than $10000 and the investor has enough money. Then reduce the MoneyToInvest by the price of the stock. If a stock cannot be bought the method should not do anything.
        /// </summary>
        /// <param name="stock"></param>
        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization >= 10000 && MoneyToInvest >= stock.PricePerShare)
            {
                portfolio.Add(stock);
                MoneyToInvest -= stock.PricePerShare;
            }

            ///TODO.....
        }

        /// <summary>
        /// 	Method string SellStock(string companyName, decimal sellPrice) - sell a Stock from the portfolio with the given company name for the given price: If the company does not exist return: "{companyName} does not exist."If the selling price is smaller than the price per share return: "Cannot sell {companyName}."Upon successful sell, you should remove the company from the portfolio, increase Money to Invest with the selling price, and return: "{companyName} was sold."
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="sellPrice"></param>
        /// <returns></returns>
        public string SellStock(string companyName, decimal sellPrice)
        {
            string text = "";

            foreach (var item in portfolio)
            {
                if (item.CompanyName == companyName)
                {
                    if (item.PricePerShare > sellPrice)
                    {
                        text = $"Cannot sell {companyName}.";
                    }
                    else
                    {
                        text = $"{companyName} was sold.";
                        portfolio.Remove(item);
                        break;
                    }
                }
                else
                {
                    text = $"{companyName} does not exist.";
                }
            }
            return text;

        }

        /// <summary>
        /// Method Stock FindStock(string companyName) - returns a Stock with the given company name. If it doesn't exist, return null.
        /// </summary>
        /// <param name="companyName"></param>
        /// <returns></returns>
        public Stock FindStock(string companyName)
        {
            Stock result = portfolio.FirstOrDefault(s => s.CompanyName == companyName);

            if (result != null)
            {
                return result;
            }

            return result;
        }

        /// <summary>
        /// Method Stock FindBiggestCompany() – returns the Stock with the biggest market capitalization. If there are no stocks in the portfolio, the method should return null. 
        /// </summary>
        /// <returns></returns>
        public Stock FindBiggestCompany()
        {
            portfolio = portfolio.OrderByDescending(m => m.MarketCapitalization).ToList();

            Stock biggestCompany = portfolio.First();

            return biggestCompany;
        }

        /// <summary>
        /// Method string InvestorInformation() - returns information about the Investor and his portfolio
        /// </summary>
        /// <returns></returns>
        public string InvestorInformation()
        {
            StringBuilder information = new StringBuilder();

            information.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");

            foreach (var item in portfolio)
            {
                information.AppendLine($"Company: {item.CompanyName}");
                information.AppendLine($"Director: {item.Director}");
                information.AppendLine($"Price per share: ${item.PricePerShare}");
                information.AppendLine($"Market capitalization: ${item.MarketCapitalization}");
            }


            return information.ToString();
        }
    }
}
