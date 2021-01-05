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
            builder.BuildPortfolio();

            builder.BuildSafeInstrument();
            builder.BuildSafeInstrument();
            builder.BuildSafeInstrument();
            builder.BuildRiskyInstrument();

            return builder.GetInvestmentPortfolio();
        }
    }
}
