using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Builder.Builders;
using Shared.Models.Builder.Instrument.Abstract;

namespace Shared.Models.Builder
{
    public class InvestmentPortfolio
    {
        public List<IInstrument> Assets { get; set; } = new List<IInstrument>();
    }
}
