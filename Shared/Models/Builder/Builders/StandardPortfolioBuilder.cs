using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Builder.Instruments;

namespace Shared.Models.Builder.Builders
{
    public class StandardPortfolioBuilder : PortfolioBuilder
    {
        public override PortfolioBuilder BuildRiskyInstrument()
        {
            _portfolio.Assets.Add(new Stock());
            return this;
        }

        public override PortfolioBuilder BuildSafeInstrument()
        {
            _portfolio.Assets.Add(new ETF());
            return this;
        }
    }
}
