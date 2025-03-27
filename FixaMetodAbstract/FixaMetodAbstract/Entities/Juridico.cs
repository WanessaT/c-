
namespace FixaMetodAbstract.Entities
{
    class Juridico : Contribuinte
    {
        public int NumeroFuncionarios { get; set; }

        public Juridico() {}

        public Juridico(string nome, double rendaAnual, int numeroFuncionarios) :
            base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Imposto()
        {
            if (NumeroFuncionarios > 10)
            {
               return RendaAnual * 0.14;
            } else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
