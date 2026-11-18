# Desafio Técnico — Revemar (C# / .NET)

Repositório contendo as duas soluções desenvolvidas em **C# (.NET 10)** para o desafio técnico da Revemar:

1. **Sistema de Gestão de Estoque de Veículos** (Aplicação Web ASP.NET Core MVC)
2. **Conversor de Moedas e Monitor de Câmbio** (Aplicação Console)

---

## 1. Sistema de Gestão de Estoque de Veículos

Aplicação web desenvolvida em **ASP.NET Core MVC** para controle e gerenciamento de estoque de veículos de forma simples, eficiente e segura.

### Funcionalidades
* Cadastro, visualização, edição e exclusão (CRUD) de veículos.
* Validação de dados no servidor e cliente utilizando *Data Annotations*.
* Persistência relacional com migrações automatizadas via Entity Framework Core.

### Tecnologias Utilizadas
* **Linguagem:** C# (.NET 10)
* **Framework Web:** ASP.NET Core MVC
* **ORM:** Entity Framework Core
* **Banco de Dados:** SQLite
* **Frontend:** Razor Views, HTML5, CSS3 e Bootstrap

---

## 2. Conversor de Moedas e Monitor de Câmbio

Aplicação Console desenvolvida em C# para realizar conversões simultâneas entre **Real (BRL)**, **Dólar (USD)** e **Euro (EUR)** a partir da escolha da moeda de origem.

### Funcionalidades e Boas Práticas Aplicadas
* **Localização e Cultura:** Configuração explícita de `CultureInfo("pt-BR")` para padronização de separadores decimais e símbolos monetários.
* **Precisão Financeira:** Uso do tipo `decimal` para evitar erros de arredondamento em cálculos cambiais.
* **Programação Defensiva:** Validação de entrada do usuário utilizando `decimal.TryParse` e bloqueio de valores negativos ou nulos.
* **Formatação de Saída:** Exibição estruturada com especificadores de formato numérico (`:C` e `:N2`).

---

## Como Executar os Projetos

### Pré-requisitos
* [.NET SDK 10.0+](https://dotnet.microsoft.com/download) instalado.

### Executando o Sistema de Gestão de Veículos (Web MVC)
```bash
cd "Controle de Estacionamento"
dotnet ef database update
dotnet run
