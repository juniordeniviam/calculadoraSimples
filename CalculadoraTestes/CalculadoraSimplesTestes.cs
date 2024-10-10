using Calculadora.Calculadora;

namespace Calculadora.CalculadoraTestes;

public class CalculadoraSimplesTestes
{
    [Fact]
    public void TestandoAdicaoDe2Mais3OndeOresultadoEh5()
    {
        //Arrange
        double num1 = 2;
        double num2 = 3;
        double resultado;
        //Act
        var calc = new CalculadoraSimples();
        resultado = calc.Adicionar(num1, num2);
        //Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void TestandoSubitracaoDe3Menos2OndeOresultadoEh1()
    {
        //Arrange
        double num1 = 3;
        double num2 = 2;
        double resultado;
        //Act
        var calc = new CalculadoraSimples();
        resultado = calc.Subtrair(num1, num2);
        //Assert
        Assert.Equal(1, resultado);
    }

    [Fact]
    public void TestandoMultiplicacaoDe2Vezes3Onde0resultadoEh6()
    {
        //Arrange
        double num1 = 2;
        double num2 = 3;
        double resultado;
        //Act
        var calc = new CalculadoraSimples();
        resultado = calc.Multiplicar(num1, num2);
        //Assert
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void TestandoDivisaoDe10por2OndeOresultadoEh5()
    {
        //Arrange
        double num1 = 10;
        double num2 = 2;
        double resultado;
        //Act
        var calc = new CalculadoraSimples();
        resultado = calc.Dividir(num1, num2);
        //Assert
        Assert.Equal(5, resultado);
    }
}