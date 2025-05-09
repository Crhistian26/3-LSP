namespace Clases
{
    public class LSP_Triangulo : LSP_FigGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        //Aca se toma el constructor del padre que captura la base y la altura
        public LSP_Triangulo(double baseFigura, double alturaFigura)
        {
            Base = baseFigura;
            Altura = alturaFigura;
        }

        //Aca se altera el calculo ya que calcularemos un triangulo
        public override double CalcularArea()
        {
            return (Base * Altura)/2;
        }
    }
}