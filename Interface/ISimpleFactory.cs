using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorySample.AbstractClass;

namespace FactorySample.Interface
{
    public interface ISimpleFactory
    {
        abstract FactoryMethod resultFactory(int tipo);
    }
}
