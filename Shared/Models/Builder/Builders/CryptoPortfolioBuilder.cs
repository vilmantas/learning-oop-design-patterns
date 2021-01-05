using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Builder.Instruments;

namespace Shared.Models.Builder.Builders
{
    public class CryptoPortfolioBuilder : PortfolioBuilder
    {
        public override void BuildRiskyInstrument()
        {
            _portfolio.Assets.Add(new CryptoCurrency());
        }

        public override void BuildSafeInstrument()
        {
            _portfolio.Assets.Add(new Stock());
        }
    }
}
