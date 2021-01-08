using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Builder.Builders;
using Shared.Models.Builder.Instrument.Abstract;

namespace Shared.Models.Builder
{
    public class InvestmentPortfolio
    {
        private readonly IInstrument _instrumentPrototype;

        public List<IInstrument> Assets { get; set; } = new List<IInstrument>();

        public InvestmentPortfolio()
        {

        }

        public InvestmentPortfolio(IInstrument instrumentPrototype)
        {
            _instrumentPrototype = instrumentPrototype;
        }

        public IInstrument CreateInstrument()
        {
            return _instrumentPrototype.Clone();
        }
    }
}
