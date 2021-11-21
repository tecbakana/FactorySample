using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorySample.AbstractClass;

namespace FactorySample.ConcreteClass
{
    class R2B : Result
    {
        public override int tipores { get; set; }
        public override string description { get; set; }

        public override Result ResultConcrete()
        {
            tipores = 2;
            description = "Resultado Tipo 2 B";
            localizacao = "Resultado 2";
            return this;
        }
    }
}
