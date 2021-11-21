using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorySample.AbstractClass;
using FactorySample.Interface;

namespace FactorySample.ConcreteClass
{
    public class SimpleFactory
    {
        public static FactoryMethod resultFactory(int tipo)
        {
            FactoryMethod fcmt;

            switch(tipo)
            {
                case 1:
                    fcmt = new FactoryR1();
                    break;
                case 2:
                    fcmt = new FactoryR2();
                    break;
                default:
                    fcmt = null;
                    break;
            }
            return fcmt;
        }
                
    }
}
