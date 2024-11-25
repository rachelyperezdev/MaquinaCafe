using MaquinaCafe.Domain.Entities;

namespace MaquinaCafe.Test
{
    public class TestMaquinaCafe
    {
        private Cafetera _cafetera;
        private Vaso _vasosPequeno;
        private Vaso _vasosMediano;
        private Vaso _vasosGrande;
        private Azucarero _azucarero;
        private MaquinaDeCafe _maquinaDeCafe;

        public TestMaquinaCafe()
        {
            _cafetera = new Cafetera(50);
            _vasosPequeno = new Vaso(5, 10);
            _vasosMediano = new Vaso(5, 20);
            _vasosGrande = new Vaso(5, 30);
            _azucarero = new Azucarero(20);

            _maquinaDeCafe = new MaquinaDeCafe
            {
                Cafetera = _cafetera,
                VasosPequenos = _vasosPequeno,
                VasosMedianos = _vasosMediano,
                VasosGrandes = _vasosGrande,
                Azucarero = _azucarero
            };
        }

        [Fact]
        public void DeberiaDevolverUnVasoPequeno()
        {
            Vaso vaso = _maquinaDeCafe.GetTipoVaso("pequeno");

            Assert.Equal(_maquinaDeCafe.VasosPequenos, vaso);
        }

        [Fact]
        public void DeberiaDevolverUnVasoMediano()
        {
            MaquinaDeCafe maquinaDeCafe = new MaquinaDeCafe();

            Vaso vaso = maquinaDeCafe.GetTipoVaso("mediano");

            Assert.Equal(maquinaDeCafe.VasosMedianos, vaso);
        }

        [Fact]
        public void DeberiaDevolverUnVasoGrande()
        {
            MaquinaDeCafe maquinaDeCafe = new MaquinaDeCafe();

            Vaso vaso = maquinaDeCafe.GetTipoVaso("grande");

            Assert.Equal(maquinaDeCafe.VasosGrandes, vaso);
        }

        [Fact]
        public void DeberiaDevolverNoHayVasos()
        {
            Vaso vaso = _maquinaDeCafe.GetTipoVaso("pequeno");

            String resultado = _maquinaDeCafe.GetVasoDeCafe(vaso, 10, 2);

            Assert.Equal("No hay vasos", resultado);
        }

        [Fact]
        public void DeberiaDevolverNoHayCafe()
        {
            _cafetera = new Cafetera(5);
            _maquinaDeCafe.Cafetera = _cafetera;

            Vaso vaso = _maquinaDeCafe.GetTipoVaso("pequeno");

            String resultado = _maquinaDeCafe.GetVasoDeCafe(vaso, 1, 2);

            Assert.Equal("No hay Cafe", resultado);
        }

        [Fact]
        public void DeberiaDevolverNoHayAzucar()
        {
            _azucarero = new Azucarero();
            _maquinaDeCafe.Azucarero = _azucarero;

            Vaso vaso = _maquinaDeCafe.GetTipoVaso("pequeno");

            String resultado = _maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);

            Assert.Equal("No hay azucar", resultado);
        }

        [Fact]
        public void DeberiaRestarAzucar()
        {
            Vaso vaso = _maquinaDeCafe.GetTipoVaso("pequeno");

            _maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);

            int resultado = _maquinaDeCafe.Azucarero.CantidadDeAzucar;

            Assert.Equal(17, resultado);
        }

        [Fact]
        public void DeberiaDevolverFelicitaciones()
        {
            Vaso vaso = _maquinaDeCafe.GetTipoVaso("pequeno");

            String resultado = _maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);

            Assert.Equal("Felicitaciones", resultado);
        }
    }
}
