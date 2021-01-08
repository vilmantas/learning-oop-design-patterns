using System;

namespace Pattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var factoryInstance = SingletonContainer.Instance;

            var factoryProduct = factoryInstance.Value.CreateAValue();

            Console.WriteLine(factoryProduct);

            Console.Read();
        }
    }
}
