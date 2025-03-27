using System;
using FixaMetodAbstract.Entities;

namespace FixaMetodAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> list = new List<Contribuinte>();

            Console.Write("Informe o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do #{i} contribuinte: ");

                Console.Write("Fisico ou juridico (f/j)? ");
                char tipoContribuinte = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());

                if (tipoContribuinte == 'f')
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine());
                    list.Add(new Fisico(nome, rendaAnual, gastosSaude));
                }
                else if (tipoContribuinte == 'j')
                {
                    Console.Write("Quantidade de funcionários: ");
                    int numeroFuncionarios = int.Parse(Console.ReadLine());
                    list.Add(new Juridico(nome, rendaAnual, numeroFuncionarios));
                }
                else
                {
                    Console.WriteLine("Tipo inválido.");
                }
            }

            double soma = 0.0;

            Console.WriteLine();

            Console.WriteLine("CONTRIBUINTES:");
            foreach (Contribuinte contribuinte in list)
            {
                double taxa = contribuinte.Imposto();
                Console.WriteLine(contribuinte.Nome + ": R$ " + taxa.ToString("F2"));
                soma += taxa;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL DE TAXAS: R$ " + soma.ToString("F2"));
        }
    }
}
