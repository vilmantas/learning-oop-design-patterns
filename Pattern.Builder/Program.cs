using System;
using Shared.Models.Builder;
using Shared.Models.Builder.Builders;
using Shared.Models.Builder.Instrument.Abstract;

namespace Pattern.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var investor = new Investor();

            var portfolio = investor.BuildInvestmentPortfolio(new StandardPortfolioBuilder());

            foreach(IInstrument portfolioAsset in portfolio.Assets)
            {
                Console.WriteLine(portfolioAsset.GetType().Name);
            }

            Console.Read();
        }
    }
}
