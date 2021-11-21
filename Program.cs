using Microsoft.Extensions.DependencyInjection;
using System;
using FactorySample.AbstractClass;
using FactorySample.ConcreteClass;

namespace FactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fcmt = SimpleFactory.resultFactory(2);
            var res = fcmt.MontaResult(1);
            Console.WriteLine($"O resultado é do tipo {res.description}");
        }
    }
}
