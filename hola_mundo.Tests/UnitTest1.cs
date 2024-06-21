namespace hola_mundo.Tests;

public class UnitTest1
{
    [Fact]
    public void Sumar_DeberiaRetornarSumaCorrecta()
    {
        // Arrange
        int a = 3;
        int b = 7;
        int esperado = 8;

        // Act
        int resultado = Program.Sumar(a, b);

        // Assert
        Assert.Equal(esperado, resultado);
    }
}