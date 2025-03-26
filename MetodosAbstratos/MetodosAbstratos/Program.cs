namespace MetodosAbstratos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Quantas figuras vai inserir?");
            int qntFiguras = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qntFiguras; i++)
            {
                Console.WriteLine($"Dados da figura #{i}:");
                Console.Write("Retangulo ou circulo (r/c)?");
                char figura = char.Parse(Console.ReadLine());

                Console.Write("Cor da fígura (Black/Blue/Red): ");
                string color = Console.ReadLine();

                if (figura == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double heigth = double.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Raio: ");
                    double radius = double.Parse(Console.ReadLine());
                }
            }
        }
    }
}
