using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Builder.Builders
{
    public abstract class PortfolioBuilder
    {
        private InvestmentPortfolio _portfolio { get; set; }

        public InvestmentPortfolio GetInvestmentPortfolio()
        {
            return _portfolio;
        }
        public abstract void BuildPortfolio();
        public abstract void BuildStockCFD();
        public abstract void BuildStock();
        public abstract void BuildCryptoCurrency();
        public abstract void BuildBond();
        public abstract void BuildStockOption();
        public abstract void BuildETF();
    }
}
