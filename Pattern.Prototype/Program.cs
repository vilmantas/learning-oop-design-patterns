using Shared.Models.Builder;
using Shared.Models.Builder.Instruments;
using System;

namespace Pattern.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            InvestmentPortfolio riskyPortfolio = new InvestmentPortfolio(new CryptoCurrency());

            var instrumentFromRiskyPrototype = riskyPortfolio.CreateInstrument();

            instrumentFromRiskyPrototype.Initialize();

            InvestmentPortfolio safePortfolio = new InvestmentPortfolio(new Stock());

            var instrumentFromSafePrototype = safePortfolio.CreateInstrument();

            instrumentFromSafePrototype.Initialize();

            Console.WriteLine($"Risky instrument: {instrumentFromRiskyPrototype.GetType().Name}. {instrumentFromRiskyPrototype.Name}");

            Console.WriteLine($"Safe instrument: {instrumentFromSafePrototype.GetType().Name}. {instrumentFromSafePrototype.Name}");

            Console.Read();
        }
    }
}
