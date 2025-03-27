namespace FixaInterfaces.Entities
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Parcelamento> Parcelamentos { get; set; }

        public Contrato(int numero, DateTime date, double totalValue)
        {
            Numero = numero;
            Date = date;
            TotalValue = totalValue;
            Parcelamentos = new List<Parcelamento>();
        }

        public void AddParcelamento(Parcelamento parcelamento)
        {
            Parcelamentos.Add(parcelamento);
        }
    }
}
