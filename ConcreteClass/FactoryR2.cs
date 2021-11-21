using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorySample.AbstractClass;

namespace FactorySample.ConcreteClass
{
    public class FactoryR2:FactoryMethod
    {
        protected  override Result CriarResult(int tipo)
        {
            Result res = null;
            if (tipo == 1)
            {
                var r = new R2A();
                res = r.ResultConcrete();
            }
            else if (tipo == 2)
            {
                var r = new R2B();
                res = r.ResultConcrete();
            }
            return res;
        }
    }
}
