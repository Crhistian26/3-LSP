namespace Clases;

public class FiguraGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public FiguraGeometrica(double baseFigura, double alturaFigura)
    {
        Base = baseFigura;
        Altura = alturaFigura;
    }

    public virtual double CalcularArea()
    {
        return Base * Altura;
    }
}
