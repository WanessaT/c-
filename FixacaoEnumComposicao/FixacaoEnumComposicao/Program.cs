using System;
using Fixacao.Entities;
using Fixacao.Entities.Enums;

namespace Fixacao
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente:");

            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Data de nascimento (DD/MM/YYYY): ");
            DateTime aniversario = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados do pedido:");
            Console.Write("Status: ");
            OrderStatus statusPedido = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(nomeCliente, email, aniversario);
            Order order = new Order(DateTime.Now, statusPedido, client);

            Console.Write("Quantos itens há neste pedido? ");
            int qntItens = int.Parse(Console.ReadLine());

            for (int n = 1;  n <= qntItens; n++)
            {
                Console.WriteLine($"Dados do pedido #{n}: ");
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();

                Console.Write("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine());

                Product produto = new Product(nomeProduto, preco);

                Console.Write("Quantidade: ");
                int qntProduto = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(qntProduto, preco, produto);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("Resumo do pedido:");
            Console.WriteLine(order);

        }
    }
}