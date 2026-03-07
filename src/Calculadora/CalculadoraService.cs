namespace Calculadora;

/// <summary>
/// Classe Calculadora — será construída incrementalmente via TDD.
/// </summary>
public class CalculadoraService
{
    // -------------------------------------------------------
    // PARTE 1 — Exemplo guiado (já implementado)
    // -------------------------------------------------------

    /// <summary>Soma dois números inteiros.</summary>
    public int Somar(int a, int b)
    {
        return a + b;
    }

    // -------------------------------------------------------
    // PARTE 2 — Implemente os métodos abaixo usando TDD
    //           (escreva o TESTE primeiro, veja falhar,
    //            depois implemente o código)
    // -------------------------------------------------------

    /// <summary>Subtrai b de a.</summary>
    public int Subtrair(int a, int b)
    {
        // TODO: Implemente usando TDD
        throw new NotImplementedException();
    }

    /// <summary>Multiplica dois números inteiros.</summary>
    public int Multiplicar(int a, int b)
    {
        // TODO: Implemente usando TDD
        throw new NotImplementedException();
    }

    /// <summary>
    /// Divide a por b. 
    /// Deve lançar DivideByZeroException quando b == 0.
    /// </summary>
    public double Dividir(int a, int b)
    {
        // TODO: Implemente usando TDD
        throw new NotImplementedException();
    }

    /// <summary>
    /// Verifica se um número é par.
    /// </summary>
    public bool EhPar(int numero)
    {
        // TODO: Implemente usando TDD
        throw new NotImplementedException();
    }

    /// <summary>
    /// Retorna o fatorial de um número não-negativo.
    /// Deve lançar ArgumentException para números negativos.
    /// </summary>
    public long Fatorial(int n)
    {
        // TODO: Implemente usando TDD
        throw new NotImplementedException();
    }
}
