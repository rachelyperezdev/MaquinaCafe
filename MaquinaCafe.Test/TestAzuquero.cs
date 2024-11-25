using MaquinaCafe.Domain.Entities;

namespace MaquinaCafe.Test
{
    public class TestAzuquero
    {
        private Azucarero _azuquero;

        public TestAzuquero()
        {
            _azuquero = new Azucarero(10);
        }

        [Fact]
        public void DeberiaDevolverVerdaderoSiHaySuficienteAzucarEnElAzuquero()
        {
            bool resultado = _azuquero.HasAzucar(5);

            Assert.True(resultado);

            resultado = _azuquero.HasAzucar(10);

            Assert.True(resultado);
        }

        [Fact]
        public void DeberiaDevolverFalsoPorqueNoHaySuficienteAzucarEnElAzuquero()
        {
            bool resultado = _azuquero.HasAzucar(15);

            Assert.False(resultado);
        }

        [Fact]
        public void DeberiaRestarAzucarAlAzuquero()
        {
            _azuquero.GiveAzucar(5);

            Assert.Equal(5, _azuquero.CantidadDeAzucar);

            _azuquero.GiveAzucar(2);

            Assert.Equal(3, _azuquero.CantidadDeAzucar);
        }
    }
}
