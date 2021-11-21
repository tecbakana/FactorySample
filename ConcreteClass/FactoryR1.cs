using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorySample.AbstractClass;

namespace FactorySample.ConcreteClass
{
    public class FactoryR1:FactoryMethod
    {
        protected  override Result CriarResult(int tipo)
        {
            Result res = null;
            if(tipo==1)
            {
                var r = new R1A();
                res = r.ResultConcrete();
            }
            else if(tipo == 2)
            {
                var r = new R1B();
                res = r.ResultConcrete();
            }
            return res;
        }
    }
}
