namespace Clases
{
    public class Circulo : FiguraGeometrica
    {
        public Circulo(double baseFigura, double alturaFigura) : base(baseFigura, alturaFigura)
        {
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}