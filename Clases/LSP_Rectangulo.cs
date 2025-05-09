namespace Clases
{
    public class LSP_Rectangulo : LSP_FigGeometrica
    {

        public double Base { get; set; }
        public double Altura { get; set; }
        //Toma el constructor del padre que captura la base y la altura
        public LSP_Rectangulo(double baseFigura, double alturaFigura)
        {
            Base = baseFigura;
            Altura = alturaFigura;
        }

        //Aca se deja igual a la clase padre, pero se puede modificar si se necesita
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}