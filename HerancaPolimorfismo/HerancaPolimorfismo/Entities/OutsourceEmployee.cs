
namespace HerancaPolimorfismo.Entities
{
    // Funcionário terceirizado está herdando os atributos que tem no funcionário normal 
    internal class OutsourceEmployee : Employee
    {
        public double AdditionalChange { get; set; }

        public OutsourceEmployee()
        {
        }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalChange)
            : base(name, hours, valuePerHour)
        {
            AdditionalChange = additionalChange;
        }

        // Pagamento do funcionário terceirizado sobrepõe o do funcionário normal, pois ele tem o adicional que entra na soma 
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalChange;
        }
    }
}
