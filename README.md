# Desafio Técnico — (C# / .NET)

Repositório contendo as duas soluções desenvolvidas em **C# (.NET)** para o desafio técnico da Revemar[span_2](start_span)[span_2](end_span)[span_3](start_span)[span_3](end_span):

1. **Sistema de Gestão de Estoque de Veículos** (Aplicação Web ASP.NET Core MVC)[span_4](start_span)[span_4](end_span)
2. **Conversor de Moedas e Monitor de Câmbio** (Aplicação Console)[span_5](start_span)[span_5](end_span)[span_6](start_span)[span_6](end_span)

---

## 1. Sistema de Gestão de Estoque de Veículos

Aplicação web desenvolvida em **ASP.NET Core MVC** para controle e gerenciamento de estoque de veículos de forma simples, eficiente e segura[span_7](start_span)[span_7](end_span).

### Funcionalidades
* Cadastro, visualização, edição e exclusão (CRUD) de veículos.
* Validação de dados no servidor e cliente utilizando *Data Annotations*.
* Persistência relacional com migrações automatizadas via Entity Framework Core.

### Tecnologias Utilizadas
* **Linguagem:** C# (.NET 8)[span_8](start_span)[span_8](end_span)
* **Framework Web:** ASP.NET Core MVC[span_9](start_span)[span_9](end_span)
* **ORM:** Entity Framework Core[span_10](start_span)[span_10](end_span)
* **Banco de Dados:** SQLite
* **Frontend:** Razor Views, HTML5, CSS3 e Bootstrap

---

## 2. Conversor de Moedas e Monitor de Câmbio

Aplicação Console desenvolvida em C# para realizar conversões simultâneas entre **Real (BRL)**, **Dólar (USD)** e **Euro (EUR)** a partir da escolha da moeda de origem[span_11](start_span)[span_11](end_span).

### Funcionalidades e Boas Práticas Aplicadas
* **Localização e Cultura:** Configuração explícita de `CultureInfo("pt-BR")` para padronização de separadores decimais e símbolos monetários[span_12](start_span)[span_12](end_span).
* **Precisão Financeira:** Uso do tipo `decimal` para evitar erros de arredondamento em cálculos cambiais[span_13](start_span)[span_13](end_span).
* **Programação Defensiva:** Validação de entrada do usuário utilizando `decimal.TryParse` e bloqueio de valores negativos ou nulos[span_14](start_span)[span_14](end_span).
* **Formatação de Saída:** Exibição estruturada com especificadores de formato numérico (`:C` e `:N2`)[span_15](start_span)[span_15](end_span).

---

## Como Executar os Projetos

### Pré-requisitos
* [.NET SDK 8.0+](https://dotnet.microsoft.com/download) instalado.

### Executando o Sistema de Gestão de Veículos (Web MVC)
```bash
cd "Controle de Estacionamento"
dotnet ef database update
dotnet run
