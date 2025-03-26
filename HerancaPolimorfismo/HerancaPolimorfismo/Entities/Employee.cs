
namespace HerancaPolimorfismo.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        // Com a propriedade 'virtual' , é permitido que a operação de pagamento seja sobrescrita
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
