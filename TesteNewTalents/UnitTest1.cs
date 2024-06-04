using NewTalents;

namespace TesteNewTalents;

public class UnitTest1
{
    // [Fact]
    // public void Test1()
    // {
    //     Calculadora calc = new Calculadora();

    //     int resultado = calc.Somar(1,2);

    //     Assert.Equal(3, resultado);
    // }

    public Calculadora ConstruirClasse()
    {
        string data = "04/06/2024";
        Calculadora calc = new Calculadora(data);

        return calc;
    }

     [Theory]
     [InlineData (1, 2, 3)]
     [InlineData (4, 5, 9)]
     public void TestSomar(int num1, int num2, int resultado)
    {
         Calculadora calc = ConstruirClasse();

         int resultadoCalculadora = calc.Somar(num1, num2);

         Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
     [InlineData (1, 2, 2)]
     [InlineData (4, 5, 20)]
     public void TesteMultipĺicar(int num1, int num2, int resultado)
    {
         Calculadora calc = ConstruirClasse();

         int resultadoCalculadora = calc.Multiplicar(num1, num2);

         Assert.Equal(resultado, resultadoCalculadora);
    }

     [Theory]
     [InlineData (6, 2, 4)]
     [InlineData (5, 5, 0)]
     public void TesteSubtrair(int num1, int num2, int resultado)
    {
         Calculadora calc = ConstruirClasse();

         int resultadoCalculadora = calc.Subtrair(num1, num2);

         Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
     [InlineData (6, 2, 3)]
     [InlineData (5, 5, 1)]
     public void TesteDividir(int num1, int num2, int resultado)
    {
         Calculadora calc = ConstruirClasse();

         int resultadoCalculadora = calc.Dividir(num1, num2);

         Assert.Equal(resultado, resultadoCalculadora);
    }
    [Fact]

    public void TesteDivisaoPorZero()
    {
        Calculadora calc = ConstruirClasse();

        Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3,0)
            );
    }
    [Fact]

    public void TestarHistorico()
    {
        Calculadora calc = ConstruirClasse();

        calc.Somar(1,2);
        calc.Somar(2,8);
        calc.Somar(3,7);
        calc.Somar(4,1);

        var Lista = calc.Historico();

        Assert.NotEmpty(Lista);
        Assert.Equal(3, Lista.Count);
    }
}