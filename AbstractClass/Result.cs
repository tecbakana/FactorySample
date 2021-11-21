using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample.AbstractClass
{
    public abstract class Result
    {
        //Obrigatório
        public abstract int tipores { get; set; }
        public abstract string description { get; set; }
        protected string localizacao { get; set; }

        public abstract Result ResultConcrete();
        //Opcional
    }
}
