using MaquinaCafe.Domain.Entities;

namespace MaquinaCafe.Test
{
    public class TestVaso
    {
        [Fact]
        public void DeberiaDevolverVerdaderoSiExistenVasos()
        {
            // Arrange
            Vaso vasosPequenos = new Vaso(2, 10);

            // Act
            bool resultado = vasosPequenos.HasVasos(1);

            // Assert
            Assert.True(resultado); 
        }

        [Fact]
        public void DeberiaDevolverFalsoSiNoExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(1, 10);

            bool resultado = vasosPequenos.HasVasos(2);

            Assert.False(resultado);
        }

        [Fact]
        public void DeberiaRestarCantidadDeVaso()
        {
            Vaso vasosPequeno = new Vaso(5, 10);

            vasosPequeno.GiveVasos(1);

            Assert.Equal(4, vasosPequeno.CantidadVasos);
        }
    }
}
