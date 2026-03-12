# 🧪 Laboratório: Testes Unitários e TDD com C# e XUnit

> **Disciplina:** Qualidade de Software  
> **Duração estimada:** 2h30  
> **Pré-requisitos:** Conta no GitHub, noções básicas de C#

---

## 📋 Sumário

1. [Objetivos de Aprendizagem](#-objetivos-de-aprendizagem)
2. [Revisão Teórica — Testes Unitários](#-revisão-teórica--testes-unitários)
3. [Revisão Teórica — TDD](#-revisão-teórica--tdd)
4. [Preparação do Ambiente](#%EF%B8%8F-preparação-do-ambiente)
5. [Estrutura do Repositório](#-estrutura-do-repositório)
6. [Parte 1 — Exemplo Guiado: Calculadora](#-parte-1--exemplo-guiado-calculadora)
7. [Parte 2 — Prática TDD: Calculadora](#-parte-2--prática-tdd-calculadora)
8. [Parte 3 — Exercício Autônomo: Conta Bancária](#-parte-3--exercício-autônomo-conta-bancária)
9. [Referência Rápida — XUnit](#-referência-rápida--xunit)
10. [Entregáveis](#-entregáveis)

---

## 🎯 Objetivos de Aprendizagem

Ao final desta atividade, você será capaz de:

- Explicar o que são testes unitários e por que são importantes para a qualidade de software.
- Aplicar o ciclo **Red → Green → Refactor** da metodologia TDD.
- Escrever testes unitários em C# utilizando o framework **XUnit**.
- Usar os atributos `[Fact]` e `[Theory]` para diferentes cenários de teste.
- Executar testes de forma interativa dentro do VS Code.
- Organizar um projeto de testes seguindo as convenções do ecossistema .NET.

---

## 📖 Revisão Teórica — Testes Unitários

### O que é um Teste Unitário?

Um **teste unitário** é um trecho de código que verifica o comportamento de uma **unidade isolada** do sistema — geralmente um método ou função. O objetivo é garantir que cada parte do código funcione corretamente de forma independente.

### Características de um bom teste unitário

| Característica | Descrição |
|---|---|
| **Rápido** | Executa em milissegundos |
| **Isolado** | Não depende de banco de dados, rede ou outros testes |
| **Repetível** | Produz o mesmo resultado toda vez que é executado |
| **Auto-verificável** | O resultado é "passou" ou "falhou" — sem inspeção manual |
| **Oportuno** | Escrito no momento certo (idealmente antes do código, no TDD) |

> Essas características formam o acrônimo **F.I.R.S.T** (Fast, Isolated, Repeatable, Self-validating, Timely).

### O padrão AAA (Arrange-Act-Assert)

Todo teste unitário segue uma estrutura de três etapas:

```
Arrange  →  Preparar os dados e objetos necessários
Act      →  Executar a ação que será testada
Assert   →  Verificar se o resultado é o esperado
```

**Exemplo concreto em C# com XUnit:**

```csharp
[Fact]
public void Somar_DoisPositivos_RetornaSoma()
{
    // Arrange — preparar
    var calc = new CalculadoraService();

    // Act — agir
    var resultado = calc.Somar(2, 3);

    // Assert — verificar
    Assert.Equal(5, resultado);
}
```

### Por que escrever testes unitários?

- **Detecção precoce de bugs:** encontra erros antes que cheguem à produção.
- **Documentação viva:** os testes descrevem o comportamento esperado do código.
- **Refatoração segura:** é possível alterar o código com confiança de que nada quebrou.
- **Redução de custo:** quanto mais cedo um defeito é encontrado, mais barato é corrigi-lo.

### Convenções de nomenclatura

Usaremos o padrão **`Método_Cenário_ResultadoEsperado`**:

```
Somar_DoisPositivos_RetornaSoma
Dividir_PorZero_LancaExcecao
EhPar_NumeroImpar_RetornaFalse
```

Isso torna os relatórios de teste autoexplicativos.

---

## 🔄 Revisão Teórica — TDD

### O que é TDD?

**Test-Driven Development** (Desenvolvimento Guiado por Testes) é uma metodologia onde os **testes são escritos antes do código de produção**. Foi popularizada por Kent Beck como parte das práticas de Extreme Programming (XP).

### O Ciclo Red → Green → Refactor

```
    ┌──────────────────────────────────────┐
    │                                      │
    │   🔴 RED                             │
    │   Escreva um teste que FALHE         │
    │                                      │
    │          │                           │
    │          ▼                           │
    │                                      │
    │   🟢 GREEN                           │
    │   Escreva o código MÍNIMO para       │
    │   o teste PASSAR                     │
    │                                      │
    │          │                           │
    │          ▼                           │
    │                                      │
    │   🔵 REFACTOR                        │
    │   Melhore o código mantendo          │
    │   todos os testes passando           │
    │                                      │
    │          │                           │
    │          └──────── ↩ Repita ─────────┘
    │
    └──────────────────────────────────────┘
```

**Detalhando cada etapa:**

| Etapa | O que fazer | Duração típica |
|---|---|---|
| 🔴 **Red** | Escrever um teste para um comportamento que *ainda não existe*. O teste deve **falhar**. | 1–3 min |
| 🟢 **Green** | Escrever o **código mínimo** necessário para que o teste passe. Não otimize ainda. | 1–5 min |
| 🔵 **Refactor** | Melhorar a estrutura do código (eliminar duplicação, renomear variáveis, simplificar lógica) **sem alterar o comportamento**. Todos os testes devem continuar passando. | 1–5 min |

### Benefícios do TDD

- **Design emergente:** o código nasce com responsabilidades claras e interfaces bem definidas.
- **Cobertura de testes alta por padrão:** se todo código nasce de um teste, a cobertura é naturalmente alta.
- **Feedback imediato:** erros são detectados em segundos, não em dias.
- **Confiança ao mudar código:** a suíte de testes funciona como uma rede de segurança.

### TDD **NÃO** é:

- ❌ Escrever o código e depois os testes (isso é "test-after").
- ❌ Escrever todos os testes de uma vez e depois todo o código.
- ❌ Uma garantia de que o software está livre de bugs (mas reduz muito o risco).

---

## ⚙️ Preparação do Ambiente

### Passo 1 — Fork do repositório

1. Acesse o repositório original no GitHub.
2. Clique no botão **"Fork"** (canto superior direito).
3. Selecione sua conta pessoal como destino.

### Passo 2 — Abrir no GitHub Codespaces

1. No **seu fork**, clique no botão verde **"<> Code"**.
2. Selecione a aba **"Codespaces"**.
3. Clique em **"Create codespace on main"**.
4. Aguarde o ambiente ser carregado (2–3 minutos na primeira vez).

> 💡 O Codespace já vem com o .NET SDK 10.0 e todas as extensões do VS Code pré-configuradas.

### Passo 3 — Verificar o ambiente

Abra o terminal integrado (`Ctrl + `` `) e execute:

```bash
dotnet --version
```

Deve exibir a versão 10.x. Em seguida, restaure os pacotes e compile:

```bash
dotnet restore
dotnet build
```

### Passo 4 — Conhecer o Test Explorer

A extensão **.NET Test Explorer** permite executar testes de forma visual:

1. Clique no ícone de **tubo de ensaio** (🧪) na barra lateral esquerda do VS Code.
2. Você verá a árvore de testes organizados por projeto e classe.
3. Clique no botão ▶️ ao lado de um teste para executá-lo individualmente.
4. Use o botão ▶️ no topo para executar **todos** os testes.

Você também pode executar testes pelo terminal:

```bash
# Executar todos os testes
dotnet test

# Executar testes de um projeto específico
dotnet test tests/Calculadora.Tests

# Executar com mais detalhes
dotnet test --verbosity normal
```

---

## 📁 Estrutura do Repositório

```
tdd-xunit-csharp/
├── .devcontainer/
│   └── devcontainer.json          ← Configuração do Codespaces
├── .vscode/
│   └── extensions.json            ← Extensões recomendadas
├── src/
│   ├── Calculadora/
│   │   ├── Calculadora.csproj     ← Projeto da biblioteca
│   │   └── CalculadoraService.cs  ← Classe com métodos a implementar
│   └── ContaBancaria/
│       ├── ContaBancaria.csproj   ← Projeto da biblioteca
│       └── Conta.cs               ← Classe para exercício autônomo
├── tests/
│   ├── Calculadora.Tests/
│   │   ├── Calculadora.Tests.csproj
│   │   └── CalculadoraServiceTests.cs  ← Testes (parcialmente prontos)
│   └── ContaBancaria.Tests/
│       ├── ContaBancaria.Tests.csproj
│       └── ContaTests.cs               ← Testes (você escreverá tudo)
├── TddXUnit.sln                   ← Solution file
├── .gitignore
└── README.md                      ← Este roteiro
```

---

## 🟢 Parte 1 — Exemplo Guiado: Calculadora

> **Objetivo:** Entender a estrutura de um teste unitário com XUnit.

### 1.1 Analisar o código existente

Abra o arquivo `src/Calculadora/CalculadoraService.cs` e observe que o método `Somar` já está implementado.

Agora abra `tests/Calculadora.Tests/CalculadoraServiceTests.cs` e analise os testes prontos para `Somar`:

- **`Somar_DoisPositivos_RetornaSoma`** — teste básico com `[Fact]`
- **`Somar_ComZero_RetornaOutroNumero`** — testa caso de borda
- **`Somar_Negativos_RetornaSomaNegativa`** — testa com negativos
- **`Somar_VariosValores_RetornaResultadoCorreto`** — teste parametrizado com `[Theory]` e `[InlineData]`

### 1.2 Executar os testes existentes

No terminal:

```bash
dotnet test tests/Calculadora.Tests --filter "Somar"
```

Ou pelo Test Explorer, expanda **Calculadora.Tests → CalculadoraServiceTests** e clique ▶️ nos testes de `Somar`.

✅ Todos os testes de `Somar` devem passar (verde).  
❌ Os demais testes devem falhar (vermelho) — pois ainda não foram implementados.

### 1.3 Pontos a observar

- O construtor da classe de teste cria a instância compartilhada (`_calc`).
- `[Fact]` é usado para testes com valores fixos.
- `[Theory]` + `[InlineData]` permite executar o mesmo teste com valores diferentes.
- Os nomes dos testes seguem o padrão `Método_Cenário_ResultadoEsperado`.

---

## 🔴 Parte 2 — Prática TDD: Calculadora

> **Objetivo:** Praticar o ciclo Red → Green → Refactor.

Para cada método (`Subtrair`, `Multiplicar`, `Dividir`, `EhPar`, `Fatorial`), siga **rigorosamente** o ciclo abaixo.

### Ciclo TDD para cada método

#### Etapa 🔴 RED — Escrever o teste

1. Abra `tests/Calculadora.Tests/CalculadoraServiceTests.cs`.
2. Encontre o teste correspondente (ex: `Subtrair_DoisPositivos_RetornaDiferenca`).
3. **Substitua** o `throw new NotImplementedException(...)` pelo código do teste real.

**Exemplo para `Subtrair`:**

```csharp
[Fact]
public void Subtrair_DoisPositivos_RetornaDiferenca()
{
    // Act
    var resultado = _calc.Subtrair(10, 3);

    // Assert
    Assert.Equal(7, resultado);
}
```

4. Execute o teste e confirme que ele **falha** (🔴).

```bash
dotnet test tests/Calculadora.Tests --filter "Subtrair_DoisPositivos"
```

#### Etapa 🟢 GREEN — Implementar o código

5. Abra `src/Calculadora/CalculadoraService.cs`.
6. Implemente o método `Subtrair` com o **código mínimo**:

```csharp
public int Subtrair(int a, int b)
{
    return a - b;
}
```

7. Execute o teste novamente e confirme que ele **passa** (🟢).

#### Etapa 🔵 REFACTOR — Melhorar

8. Há algo para melhorar? Neste caso, o código já está limpo. Em métodos mais complexos, esta é a hora de eliminar duplicação e melhorar nomes.

9. **Repita** para os demais testes do mesmo método e para os outros métodos.

### Dicas para os métodos mais complexos

**`Dividir`** — Para testar exceções, use:

```csharp
[Fact]
public void Dividir_PorZero_LancaExcecao()
{
    Assert.Throws<DivideByZeroException>(() => _calc.Dividir(10, 0));
}
```

**`Fatorial`** — Para testar exceções com mensagem:

```csharp
[Fact]
public void Fatorial_Negativo_LancaArgumentException()
{
    Assert.Throws<ArgumentException>(() => _calc.Fatorial(-1));
}
```

---

## 🏦 Parte 3 — Exercício Autônomo: Conta Bancária

> **Objetivo:** Aplicar TDD do zero em um cenário mais realista.

Neste exercício, você vai praticar TDD de forma autônoma com a classe `Conta` (conta bancária).

### Requisitos

Abra o arquivo `src/ContaBancaria/Conta.cs` e leia a documentação de cada método. Você encontrará:

| Método | Regras |
|---|---|
| **Construtor** | Titular obrigatório, saldo ≥ 0, conta ativa |
| **Depositar** | Valor > 0, conta ativa |
| **Sacar** | Valor > 0, conta ativa, saldo suficiente |
| **Transferir** | Ambas ativas, valor > 0, saldo suficiente |
| **Encerrar** | Conta ativa, saldo = 0 |

### Instruções

1. Abra `tests/ContaBancaria.Tests/ContaTests.cs`.
2. Leia as **sugestões de testes** nos comentários.
3. Para **cada método**, siga o ciclo TDD:
   - 🔴 Escreva **um** teste → execute → veja falhar.
   - 🟢 Implemente o código mínimo em `Conta.cs` → execute → veja passar.
   - 🔵 Refatore se necessário.
   - Repita para o próximo cenário de teste.

### Exemplo de início — Teste do construtor

```csharp
[Fact]
public void Construtor_DadosValidos_CriaContaCorretamente()
{
    // Arrange & Act
    var conta = new Conta("Maria", 100);

    // Assert
    Assert.Equal("Maria", conta.Titular);
    Assert.Equal(100, conta.Saldo);
    Assert.True(conta.Ativa);
}

[Fact]
public void Construtor_TitularNulo_LancaArgumentException()
{
    Assert.Throws<ArgumentException>(() => new Conta(null!));
}
```

> ⚠️ **Mínimo exigido:** Crie pelo menos **15 testes** cobrindo todos os métodos da classe `Conta`.

### Executar testes do projeto ContaBancaria

```bash
dotnet test tests/ContaBancaria.Tests
```

---

## 📘 Referência Rápida — XUnit

### Atributos de teste

| Atributo | Uso |
|---|---|
| `[Fact]` | Teste com valores fixos (sem parâmetros) |
| `[Theory]` | Teste parametrizado (executado N vezes) |
| `[InlineData(...)]` | Fornece dados inline para `[Theory]` |

### Assertions comuns

```csharp
// Igualdade
Assert.Equal(esperado, resultado);

// Booleanos
Assert.True(condicao);
Assert.False(condicao);

// Nulos
Assert.Null(objeto);
Assert.NotNull(objeto);

// Exceções
Assert.Throws<TipoExcecao>(() => metodoQueLanca());

// Strings
Assert.Contains("texto", resultado);
Assert.StartsWith("prefixo", resultado);

// Coleções
Assert.Empty(lista);
Assert.Contains(item, lista);
Assert.Equal(tamanhoEsperado, lista.Count);

// Intervalos numéricos (para doubles)
Assert.InRange(resultado, minimo, maximo);
```

### Executando testes no terminal

```bash
# Todos os testes
dotnet test

# Projeto específico
dotnet test tests/Calculadora.Tests

# Filtrar por nome
dotnet test --filter "NomeDoTeste"

# Filtrar por classe
dotnet test --filter "FullyQualifiedName~CalculadoraServiceTests"

# Com detalhes
dotnet test --verbosity normal

# Com cobertura (requer coverlet)
dotnet test --collect:"XPlat Code Coverage"
```

---

## 📦 Entregáveis

Para comprovar a realização da atividade, você deve entregar as seguintes evidências no **seu fork** do repositório:

### ✅ Checklist obrigatório

| # | Entregável | Descrição | Arquivo |
|---|---|---|---|
| 1 | **Testes da Calculadora** | Todos os testes em `CalculadoraServiceTests.cs` implementados (sem `NotImplementedException`) | `tests/Calculadora.Tests/CalculadoraServiceTests.cs` |
| 2 | **Código da Calculadora** | Todos os métodos de `CalculadoraService.cs` implementados (sem `NotImplementedException`) | `src/Calculadora/CalculadoraService.cs` |
| 3 | **Testes da Conta Bancária** | Mínimo de **15 testes** escritos do zero em `ContaTests.cs` | `tests/ContaBancaria.Tests/ContaTests.cs` |
| 4 | **Código da Conta Bancária** | Classe `Conta.cs` totalmente implementada | `src/ContaBancaria/Conta.cs` |
| 5 | **Todos os testes passando** | Screenshot ou saída do terminal mostrando `dotnet test` com todos os testes passando | Incluir no commit |
| 6 | **Histórico de commits** | Commits **incrementais** mostrando o ciclo TDD (ex: "red: teste Subtrair", "green: implementa Subtrair") | Histórico do Git |

### 📸 Screenshot dos testes

Após concluir, execute e capture a saída:

```bash
dotnet test --verbosity normal > resultado-testes.txt 2>&1
```

Faça o commit do arquivo `resultado-testes.txt` junto com seu código.

### 🔀 Padrão de commits (recomendado)

Use prefixos para documentar o ciclo TDD nos commits:

```
red:      teste para Subtrair - dois positivos
green:    implementa Subtrair
refactor: simplifica lógica do Subtrair

red:      teste para Dividir por zero  
green:    implementa Dividir com validação
refactor: extrai validação para método privado
```

### 📤 Como entregar

1. Faça commit de todas as alterações:
   ```bash
   git add .
   git commit -m "Atividade TDD completa"
   git push origin main
   ```
2. Confirme que o código está no **seu fork** no GitHub.
3. Envie o **link do seu repositório (fork)** no ambiente virtual da disciplina.

---

## 📚 Referências

- [XUnit — Documentação Oficial](https://xunit.net/)
- [Testes unitários no .NET — Microsoft Learn](https://learn.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-dotnet-test)
- [TDD — Martin Fowler](https://martinfowler.com/bliki/TestDrivenDevelopment.html)
- [Padrão AAA — Arrange, Act, Assert](https://learn.microsoft.com/pt-br/visualstudio/test/unit-test-basics)

---

> **Bom trabalho!** Lembre-se: no TDD, o teste sempre vem primeiro. 🧪🔴🟢🔵
