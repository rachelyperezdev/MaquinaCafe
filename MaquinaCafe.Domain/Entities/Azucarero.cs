namespace MaquinaCafe.Domain.Entities
{
    public class Azucarero
    {
        private int cantidadAzucar;

        public Azucarero()
        {
            cantidadAzucar = 0;
        }

        public Azucarero(int cantidad)
        {
            if(cantidad == 0)
            {
                Console.WriteLine("No puede ingresar nada al azucarero.");
                return;
            }

            if(cantidad < 0)
            {
                Console.WriteLine("No puede ingresar una cantidad negativa al azucarero.");
                return;
            }

            cantidadAzucar = cantidad;
        }

        public int CantidadDeAzucar => cantidadAzucar;

        public bool HasAzucar(int cantidad) => cantidadAzucar >= cantidad;

        public void GiveAzucar(int cantidad)
        {
            if(cantidad == 0)
            {
                Console.WriteLine("No puede retirar nada de azúcar.");
                return;
            }

            if(cantidad < 0)
            {
                Console.WriteLine("No puede retirar una cantidad negativa de azúcar.");
                return;
            }

            if(cantidadAzucar < cantidad)
            {
                Console.WriteLine("No hay suficiente azúcar.");
                return;
            }

            cantidadAzucar -= cantidad;
        }
    }
}
