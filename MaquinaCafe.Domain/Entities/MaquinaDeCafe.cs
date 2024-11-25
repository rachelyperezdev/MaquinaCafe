namespace MaquinaCafe.Domain.Entities
{
    public class MaquinaDeCafe
    {
        public Cafetera Cafetera { get; set; }
        public Vaso VasosPequenos { get; set; }
        public Vaso VasosMedianos { get; set; }
        public Vaso VasosGrandes { get; set; }
        public Azucarero Azucarero { get; set; }

        public MaquinaDeCafe(
                             Cafetera cafetera, 
                             Vaso vasosPequenos, 
                             Vaso vasosMedianos, 
                             Vaso vasosGrandes, 
                             Azucarero azucarero)
        {
            Cafetera = cafetera;
            VasosPequenos = vasosPequenos;
            VasosMedianos = vasosMedianos;
            VasosGrandes = vasosGrandes;
            Azucarero = azucarero;
        }

        public MaquinaDeCafe()
        {
            
        }

        public Vaso GetTipoVaso(String tipo)
        {
            return tipo.ToLower() switch 
            {
                "pequeno" => VasosPequenos,
                "mediano" => VasosMedianos,
                "grande" => VasosGrandes,
                _ => VasosPequenos
            };
        }

        public String GetVasoDeCafe(Vaso vaso, int cantidadVasos, int cantidadAzucar)
        {
            if (vaso.CantidadVasos < cantidadVasos) return "No hay vasos";

            int cantidadCafeNecesaria = cantidadVasos * vaso.Contenido;

            if (Cafetera.CantidadDeCafe < cantidadCafeNecesaria) return "No hay Cafe";

            if (!Azucarero.HasAzucar(cantidadAzucar)) return "No hay azucar";

            vaso.GiveVasos(cantidadVasos);
            Cafetera.GiveCafe(cantidadCafeNecesaria);
            Azucarero.GiveAzucar(cantidadAzucar);

            return "Felicitaciones";
        }
    }
}
