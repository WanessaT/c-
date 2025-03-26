
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    class Retangulo : Figura
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangulo()
        {
        }

        public Retangulo(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;

        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
