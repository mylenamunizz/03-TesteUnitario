using Xunit;
using ContaBancaria;

namespace ContaBancaria.Tests;

/// <summary>
/// Testes unitários para a classe Conta.
/// 
/// EXERCÍCIO AUTÔNOMO — Você deve escrever TODOS os testes.
/// 
/// Para cada método da classe Conta, crie testes que cubram:
///   ✅ O cenário de sucesso (caminho feliz)
///   ❌ Cada regra de validação (cenários de exceção)
///   🔄 Casos de borda (valores limites)
/// 
/// Siga rigorosamente o ciclo TDD: Red → Green → Refactor
/// </summary>
public class ContaTests
{
    // =======================================================
    //  Testes do Construtor
    //  Sugestão de testes:
    //    - Criar conta com dados válidos
    //    - Criar conta com saldo inicial personalizado
    //    - Titular nulo deve lançar ArgumentException
    //    - Titular vazio deve lançar ArgumentException
    //    - Saldo inicial negativo deve lançar ArgumentException
    //    - Conta nova deve estar ativa
    // =======================================================


    // =======================================================
    //  Testes para Depositar
    //  Sugestão de testes:
    //    - Depósito com valor válido atualiza o saldo
    //    - Depósito com valor zero lança ArgumentException
    //    - Depósito com valor negativo lança ArgumentException
    //    - Depósito em conta inativa lança InvalidOperationException
    // =======================================================


    // =======================================================
    //  Testes para Sacar
    //  Sugestão de testes:
    //    - Saque com valor válido atualiza o saldo
    //    - Saque com valor maior que saldo lança InvalidOperationException
    //    - Saque com valor zero lança ArgumentException
    //    - Saque com valor negativo lança ArgumentException
    //    - Saque em conta inativa lança InvalidOperationException
    // =======================================================


    // =======================================================
    //  Testes para Transferir
    //  Sugestão de testes:
    //    - Transferência válida atualiza saldo de ambas as contas
    //    - Transferência com saldo insuficiente lança exceção
    //    - Transferência com valor zero/negativo lança exceção
    //    - Transferência com conta origem inativa lança exceção
    //    - Transferência com conta destino inativa lança exceção
    // =======================================================


    // =======================================================
    //  Testes para Encerrar
    //  Sugestão de testes:
    //    - Encerrar conta com saldo zero funciona
    //    - Encerrar conta com saldo lança InvalidOperationException
    //    - Encerrar conta já inativa lança InvalidOperationException
    //    - Conta encerrada tem Ativa == false
    // =======================================================

}
