namespace Clases
{
    public class LSP_Circulo : LSP_FigGeometrica
    {
        public double Radio { get; set; }
        //Toma el constructor del padre que captura el radio
        public LSP_Circulo(double radio)
        {
            Radio = radio;
        }

        //Aca se altera el calculo ya que es el radio que usaremos no la base ni la altura
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}