namespace MaquinaCafe.Domain.Entities
{
    public class Vaso
    {
        public int CantidadVasos {  get; private set; }
        public int Contenido { get; private set; }

        public Vaso(int cantidad = 0, int contenido = 0)
        {
            if (cantidad < 1) 
            {
                Console.WriteLine("La cantidad de vasos no puede ser negativa.");
                return;
            }

            if (contenido < 1)
            {
                Console.WriteLine("El contenido de los vasos no puede ser negativo.");
                return;
            }

            CantidadVasos = cantidad;
            Contenido = contenido;
        }

        public bool HasVasos(int cantidad) => CantidadVasos >= cantidad;

        public void GiveVasos(int cantidad)
        {
            if(cantidad < 1)
            {
                Console.WriteLine("La cantidad de vasos no puede ser negativa.");
                return;
            }

            if(CantidadVasos < cantidad)
            {
                Console.WriteLine("No hay suficientes vasos.");
                return;
            }

            CantidadVasos -= cantidad;
        }
    }
}
