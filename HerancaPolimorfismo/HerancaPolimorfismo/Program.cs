using HerancaPolimorfismo.Entities;

namespace HerancaPolimorfismo
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Lista de funcionários
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Quantos funcionários você tem?");
            int qntFuncionarios = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qntFuncionarios; i++)
            {
                Console.WriteLine($"Dados do funcionário #{i}:");
                Console.WriteLine("É terceirizado (s/n)? ");
                char terceirizado = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Horas trabalhadas: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valuePerHour = int.Parse(Console.ReadLine());

                if (terceirizado == 's')
                {
                    Console.Write("Valor do adicional: ");
                    double additionalChange = double.Parse(Console.ReadLine());
                    list.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalChange));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");
            foreach (Employee employee in list)
            {
                Console.WriteLine(employee.Name + " - R$ " + employee.Payment().ToString("F2"));
            }
        }
    }
}
