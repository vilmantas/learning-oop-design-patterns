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

        public virtual void BuildPortfolio()
        {
            _portfolio = new InvestmentPortfolio();
        }

        public virtual void BuildSafeInstrument()
        {

        }

        public virtual void BuildRiskyInstrument()
        {

        }
    }
}
