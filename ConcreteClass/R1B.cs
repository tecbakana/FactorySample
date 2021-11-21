using FactorySample.AbstractClass;

namespace FactorySample.ConcreteClass
{
    public class R1B : Result
    {
        public override int tipores { get; set; }
        public override string description { get; set; }

        public override Result ResultConcrete()
        {
            tipores = 1;
            description = "Resultado Tipo 1 B";
            localizacao = "Resultado 1";
            return this;
        }
    }
}
