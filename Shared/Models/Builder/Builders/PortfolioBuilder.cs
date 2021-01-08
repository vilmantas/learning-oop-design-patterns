using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Builder.Builders
{
    public class PortfolioBuilder
    {
        protected InvestmentPortfolio _portfolio { get; set; }

        public InvestmentPortfolio GetInvestmentPortfolio()
        {
            return _portfolio;
        }

        public virtual PortfolioBuilder BuildPortfolio()
        {
            _portfolio = new InvestmentPortfolio();
            return this;
        }

        public virtual PortfolioBuilder BuildSafeInstrument()
        {
            return this;
        }

        public virtual PortfolioBuilder BuildRiskyInstrument()
        {
            return this;
        }
    }
}
