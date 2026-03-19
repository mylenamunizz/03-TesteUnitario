namespace ContaBancaria;

/// <summary>
/// Classe Conta Bancária — laboratório de Testes Unitários e TDD.
/// </summary>
public class Conta
{
    public string Titular { get; private set; }
    public decimal Saldo { get; private set; }
    public bool Ativa { get; private set; }

    /// <summary>
    /// Cria uma conta bancária.
    /// </summary>
    public Conta(string titular, decimal saldoInicial = 0)
    {
        if (string.IsNullOrWhiteSpace(titular))
            throw new ArgumentException("O titular não pode ser nulo ou vazio.", nameof(titular));
        if (saldoInicial < 0)
            throw new ArgumentException("O saldo inicial não pode ser negativo.", nameof(saldoInicial));

        Titular = titular;
        Saldo = saldoInicial;
        Ativa = true;
    }

    /// <summary>
    /// Deposita um valor na conta.
    /// </summary>
    public void Depositar(decimal valor)
    {
        if (!Ativa)
            throw new InvalidOperationException("Não é possível depositar em uma conta inativa.");

        if (valor <= 0)
            throw new ArgumentException("O valor do depósito deve ser maior que zero.", nameof(valor));

        Saldo += valor;
    }

    /// <summary>
    /// Saca um valor da conta.
    /// </summary>
    public void Sacar(decimal valor)
    {
        if (!Ativa)
            throw new InvalidOperationException("Não é possível sacar de uma conta inativa.");

        if (valor <= 0)
            throw new ArgumentException("O valor do saque deve ser maior que zero.", nameof(valor));

        if (valor > Saldo)
            throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");

        Saldo -= valor;
    }

    /// <summary>
    /// Transfere valor desta conta para outra.
    /// </summary>
    public void Transferir(Conta destino, decimal valor)
    {
        if (!Ativa)
            throw new InvalidOperationException("A conta de origem está inativa.");

        if (destino == null || !destino.Ativa)
            throw new InvalidOperationException("A conta de destino é inválida ou está inativa.");

        // Dica Ninja: Em vez de duplicar as validações de valor e saldo, 
        // podemos simplesmente reutilizar os métodos Sacar e Depositar!
        this.Sacar(valor);
        destino.Depositar(valor);
    }

    /// <summary>
    /// Encerra a conta.
    /// </summary>
    public void Encerrar()
    {
        if (!Ativa)
            throw new InvalidOperationException("A conta já está inativa.");

        if (Saldo != 0)
            throw new InvalidOperationException("A conta precisa ter saldo zero para ser encerrada.");

        Ativa = false;
    }
}