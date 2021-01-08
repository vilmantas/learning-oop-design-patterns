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

            Console.WriteLine(" --- standard portfolio builder ---");
            Console.WriteLine();
            foreach(IInstrument portfolioAsset in portfolio.Assets)
            {
                Console.WriteLine(portfolioAsset.GetType().Name);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" --- crypto portfolio builder ---");
            Console.WriteLine();
            portfolio = investor.BuildInvestmentPortfolio(new CryptoPortfolioBuilder());

            foreach (IInstrument portfolioAsset in portfolio.Assets)
            {
                Console.WriteLine(portfolioAsset.GetType().Name);
            }


            Console.Read();
        }
    }
}
