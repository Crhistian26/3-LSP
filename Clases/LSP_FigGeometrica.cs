namespace Clases
{
    public class LSP_FigGeometrica
    {
        //Cree estos 3 atributos para poder calcular el area de un circulo y un rectangulo
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Radio { get; set; }

        //Cree estos 3 constructores para poder inicializar los atributos de la clase dependiendo de la figura geometrica
        public LSP_FigGeometrica(double radioFigura)
        {
            Radio = radioFigura;
        }

        public LSP_FigGeometrica(double baseFigura, double alturaFigura)
        {
            Base = baseFigura;
            Altura = alturaFigura;
        }

        public LSP_FigGeometrica(double baseFigura, double alturaFigura, double radioFigura) 
            : this(baseFigura, alturaFigura)
        {
            Radio = radioFigura;
        }


        //Cree este metodo para poder calcular el area, si se necesita modificar despues se hace override
        public virtual double CalcularArea()
        {
            return Base * Altura;
        }
    }
}