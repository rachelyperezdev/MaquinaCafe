namespace MaquinaCafe.Domain.Entities
{
    public class Cafetera
    {
        private int cantidadCafe;

        public Cafetera(int cantidad)
        {
            if (cantidad == 0)
            {
                Console.WriteLine("No puede ingresar nada a la cafetera.");
                return;
            }

            if (cantidad < 0)
            {
                Console.WriteLine("La cantidad de café no puede ser negativa.");
                return;
            }

            cantidadCafe = cantidad;
        }

        public int CantidadDeCafe => cantidadCafe;

        public bool HasCafe(int cantidad) => cantidadCafe > cantidad;

        public void GiveCafe(int cantidad)
        {
            if (cantidad == 0)
            {
                Console.WriteLine("No puede retirar nada de café.");
                return;
            }

            if (cantidad < 0)
            {
                Console.WriteLine("No puede retirar una cantidad negativa de café.");
                return;
            }

            if (cantidadCafe < cantidad)
            {
                Console.WriteLine("No hay suficiente azúcar.");
                return;
            }

            cantidadCafe -= cantidad;
        }
    }
}
