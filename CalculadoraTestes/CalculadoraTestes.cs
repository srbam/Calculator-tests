using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        int num1 = 5;
        int num2 = 10;

        int resultado = _calc.Somar(num1, num2);

        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSubtrair5Com10ERetornar5Negativo()
    {
        int num1 = 5;
        int num2 = 10;

        int resultado = _calc.Subtrair(num1, num2);

        Assert.Equal(-5, resultado);
    }

    [Fact]
    public void DeveMultiplicar10por5eRetornar50()
    {
        int num1 = 10;
        int num2 = 5;

        int resultado = _calc.Multiplicar(num1, num2);

        Assert.Equal(50, resultado);
    }

    [Fact]
    public void DeveDividir10por5eRetornar2()
    {
        int num1 = 10;
        int num2 = 5;

        int resultado = _calc.Dividir(num1, num2);

        Assert.Equal(2, resultado);
    }
    
}