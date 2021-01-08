using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Builder.Instrument.Abstract;

namespace Shared.Models.Builder.Instruments
{
    public class Stock : IInstrument
    {
        public string Name { get; set; }

        public Stock()
        {

        }

        public Stock(Stock self)
        {
        }

        public IInstrument Clone()
        {
            return new Stock(this);
        }

        public void Initialize()
        {
            Name = "Stock instrument";
        }
    }
}
