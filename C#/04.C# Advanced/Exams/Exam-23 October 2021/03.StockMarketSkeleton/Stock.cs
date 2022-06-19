﻿using System.Text;

namespace StockMarket
{
    public class Stock
    {
        //Fields
        private decimal marketCapitalization;
        //Properties
        public string CompanyName { get; set; }
        public string Director { get; set; }
        public decimal PricePerShare { get; set; }
        public int TotalNumberOfShares { get; set; }
        public decimal MarketCapitalization
        {
            get { return marketCapitalization = PricePerShare * TotalNumberOfShares; }
            set { this.marketCapitalization = value; }
        }

        //Constructor
        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            CompanyName = companyName;
            Director = director;
            PricePerShare = pricePerShare;
            TotalNumberOfShares = totalNumberOfShares;
        }

        //Output
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Company: {CompanyName}");
            sb.AppendLine($"Director: {Director}");
            sb.AppendLine($"Price per share: ${PricePerShare}");
            sb.AppendLine($"Market capitalization: ${MarketCapitalization}");

            return sb.ToString();
        }

    }
}
