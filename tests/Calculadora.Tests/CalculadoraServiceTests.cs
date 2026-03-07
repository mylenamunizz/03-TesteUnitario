using Xunit;
using Calculadora;

namespace Calculadora.Tests;

/// <summary>
/// Testes unitários para a CalculadoraService.
/// 
/// PARTE 1 — Testes de exemplo (Somar) já estão prontos.
/// PARTE 2 — Você deve escrever os testes ANTES de implementar o código.
/// </summary>
public class CalculadoraServiceTests
{
    private readonly CalculadoraService _calc;

    public CalculadoraServiceTests()
    {
        // Arrange global — instância compartilhada por todos os testes
        _calc = new CalculadoraService();
    }

    // =======================================================
    //  PARTE 1 — EXEMPLO GUIADO: Testes para Somar
    //  Observe o padrão Arrange-Act-Assert (AAA)
    // =======================================================

    [Fact]
    public void Somar_DoisPositivos_RetornaSoma()
    {
        // Arrange — já feito no construtor

        // Act
        var resultado = _calc.Somar(2, 3);

        // Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Somar_ComZero_RetornaOutroNumero()
    {
        var resultado = _calc.Somar(7, 0);
        Assert.Equal(7, resultado);
    }

    [Fact]
    public void Somar_Negativos_RetornaSomaNegativa()
    {
        var resultado = _calc.Somar(-4, -6);
        Assert.Equal(-10, resultado);
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(0, 0, 0)]
    [InlineData(-1, 1, 0)]
    [InlineData(100, 200, 300)]
    public void Somar_VariosValores_RetornaResultadoCorreto(int a, int b, int esperado)
    {
        var resultado = _calc.Somar(a, b);
        Assert.Equal(esperado, resultado);
    }

    // =======================================================
    //  PARTE 2 — ESCREVA OS TESTES ABAIXO (TDD)
    //  Lembre-se: escreva o teste PRIMEIRO, veja FALHAR (Red),
    //  depois implemente o código para PASSAR (Green),
    //  e por fim faça Refactor se necessário.
    // =======================================================

    // -------------------------------------------------------
    //  Testes para Subtrair
    // -------------------------------------------------------

    [Fact]
    public void Subtrair_DoisPositivos_RetornaDiferenca()
    {
        // TODO: Escreva o teste
        // Dica: _calc.Subtrair(10, 3) deve retornar 7
        throw new NotImplementedException("Implemente este teste!");
    }

    [Fact]
    public void Subtrair_ResultadoNegativo_RetornaNegativo()
    {
        // TODO: Escreva o teste
        // Dica: _calc.Subtrair(3, 10) deve retornar -7
        throw new NotImplementedException("Implemente este teste!");
    }

    // -------------------------------------------------------
    //  Testes para Multiplicar
    // -------------------------------------------------------

    [Fact]
    public void Multiplicar_DoisPositivos_RetornaProduto()
    {
        // TODO: Escreva o teste
        throw new NotImplementedException("Implemente este teste!");
    }

    [Fact]
    public void Multiplicar_PorZero_RetornaZero()
    {
        // TODO: Escreva o teste
        throw new NotImplementedException("Implemente este teste!");
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(-2, 3, -6)]
    [InlineData(-2, -3, 6)]
    [InlineData(0, 100, 0)]
    public void Multiplicar_VariosValores_RetornaResultadoCorreto(int a, int b, int esperado)
    {
        // TODO: Escreva o teste usando os parâmetros recebidos
        throw new NotImplementedException("Implemente este teste!");
    }

    // -------------------------------------------------------
    //  Testes para Dividir
    // -------------------------------------------------------

    [Fact]
    public void Dividir_DoisInteiros_RetornaQuociente()
    {
        // TODO: Escreva o teste
        // Dica: _calc.Dividir(10, 2) deve retornar 5.0
        throw new NotImplementedException("Implemente este teste!");
    }

    [Fact]
    public void Dividir_PorZero_LancaExcecao()
    {
        // TODO: Escreva o teste que verifica se DivideByZeroException é lançada
        // Dica: use Assert.Throws<DivideByZeroException>(...)
        throw new NotImplementedException("Implemente este teste!");
    }

    // -------------------------------------------------------
    //  Testes para EhPar
    // -------------------------------------------------------

    [Fact]
    public void EhPar_NumeroPar_RetornaTrue()
    {
        // TODO: Escreva o teste
        throw new NotImplementedException("Implemente este teste!");
    }

    [Fact]
    public void EhPar_NumeroImpar_RetornaFalse()
    {
        // TODO: Escreva o teste
        throw new NotImplementedException("Implemente este teste!");
    }

    // -------------------------------------------------------
    //  Testes para Fatorial
    // -------------------------------------------------------

    [Fact]
    public void Fatorial_DeZero_RetornaUm()
    {
        // TODO: Escreva o teste
        // Dica: 0! = 1
        throw new NotImplementedException("Implemente este teste!");
    }

    [Fact]
    public void Fatorial_DeCinco_RetornaCentoEVinte()
    {
        // TODO: Escreva o teste
        // Dica: 5! = 120
        throw new NotImplementedException("Implemente este teste!");
    }

    [Fact]
    public void Fatorial_Negativo_LancaArgumentException()
    {
        // TODO: Escreva o teste que verifica se ArgumentException é lançada
        throw new NotImplementedException("Implemente este teste!");
    }
}
