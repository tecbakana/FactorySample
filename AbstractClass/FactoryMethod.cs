using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample.AbstractClass
{
    public abstract class FactoryMethod
    {
        public Result MontaResult(int tipo)
        {
            Result result;
            result = CriarResult(tipo);
            return result;
        }

        protected abstract Result CriarResult(int tipo);
        
    }
}
