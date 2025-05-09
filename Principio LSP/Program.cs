using Clases;

namespace Principio_LSP;

class Program
{
    static void Main(string[] args)
    {
        
        FiguraGeometrica figuraGeometrica = new FiguraGeometrica(5, 10);
        Rectangulo rectangulo = new Rectangulo(5, 10);
        Circulo circulo = new Circulo(5, 10);

        Console.WriteLine("Sin el Principio de Sustitucion de Liskov:\n");
        Console.WriteLine($"Area de la figura geometrica: {figuraGeometrica.CalcularArea()}");
        Console.WriteLine($"Area del rectangulo: {rectangulo.CalcularArea()}");        
        Console.WriteLine($"Area del circulo: {circulo.CalcularArea()}");


        LSP_FigGeometrica figuraGeometricaLSP = new LSP_FigGeometrica(5, 10);
        LSP_FigGeometrica rectanguloLSP = new LSP_Rectangulo(5, 10);
        LSP_FigGeometrica circuloLSP = new LSP_Circulo(5);
        LSP_FigGeometrica trianguloLSP = new LSP_Triangulo(5, 10);
        Console.WriteLine("\nCon el Principio de Sustitucion de Liskov:\n");

        Console.WriteLine($"Area de la figura geometrica: {figuraGeometricaLSP.CalcularArea()}");
        Console.WriteLine($"Area del rectangulo: {rectanguloLSP.CalcularArea()}");
        Console.WriteLine($"Area del circulo: {circuloLSP.CalcularArea()}");
        Console.WriteLine($"Area del triangulo: {trianguloLSP.CalcularArea()}");


    }
}
