using System;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    class Circulo : Figura
    {
        public double Radius { get; set; }

        public Circulo()
        {
        }

        public Circulo(double radius, Color color) : base(color) 
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
