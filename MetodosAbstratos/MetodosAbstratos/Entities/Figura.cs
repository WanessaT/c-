
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    // Se uma classe tem uma operação anônima, a classe precisa ser abstrata também
    abstract class Figura
    {
        public Color Color { get; set; }

        public Figura()
        {
        }

        public Figura(Color color)
        {
            Color = color;
        }

        // A operação area não pode ter retorno pois seu calculo será diferente a depender da figura
        public abstract double Area();
    }
}
