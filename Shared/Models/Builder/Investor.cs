using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Builder.Builders;

namespace Shared.Models.Builder
{
    public class Investor 
    {
        public InvestmentPortfolio InvestmentPortfolio { get; set; }

        public InvestmentPortfolio BuildInvestmentPortfolio(PortfolioBuilder builder)
        {
            return builder.BuildPortfolio()
                          .BuildSafeInstrument()
                          .BuildSafeInstrument()
                          .BuildRiskyInstrument()
                          .BuildRiskyInstrument()
                          .GetInvestmentPortfolio();
        }
    }
}
