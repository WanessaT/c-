
namespace FixaInterfaces.Entities
{
    class Parcelamento
    {
        public DateTime Vencimento { get; set; }
        public double Quantia { get; set; }

        public Parcelamento(DateTime vencimento, double quantia)
        {
            Vencimento = vencimento;
            Quantia = quantia;
        }

        public override string ToString()
        {
            return Vencimento.ToString("dd/MM/yyyy")
            + " - "
            + Quantia.ToString("F2");
        }
    }
}
