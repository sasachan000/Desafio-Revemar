using System;
using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

decimal taxaDolarEmReal = 5.14m;
decimal taxaEuroEmReal = 5.60m;

Console.WriteLine("==========================================");
Console.WriteLine(" CONVERSOR DE MOEDAS E MONITOR DE CÂMBIO ");
Console.WriteLine("==========================================");
Console.WriteLine();

Console.WriteLine("Escolha a moeda de origem:");
Console.WriteLine("1 - Real (BRL)");
Console.WriteLine("2 - Dólar (USD)");
Console.WriteLine("3 - Euro (EUR)");
Console.Write("Opção desejada (1, 2 ou 3): ");

string? opcao = Console.ReadLine();

Console.Write("\nDigite o valor a ser convertido: ");

string? entradaValor = Console.ReadLine();

if (!decimal.TryParse(entradaValor, out decimal valor) || valor <= 0)
{
    Console.WriteLine("Valor inválido! Digite um número positivo.");
    return;
}

Console.WriteLine("\n------------------------------------------");
Console.WriteLine("RESULTADO DA CONVERSÃO:");
Console.WriteLine("------------------------------------------");

switch (opcao)
{
    case "1":
        decimal realParaDolar = valor / taxaDolarEmReal;
        decimal realParaEuro = valor / taxaEuroEmReal;

        Console.WriteLine($"Valor em Real: {valor:C}");
        Console.WriteLine($"Convertido para Dólar: $ {realParaDolar:N2}");
        Console.WriteLine($"Convertido para Euro: € {realParaEuro:N2}");
        break;

    case "2":
        decimal dolarParaReal = valor * taxaDolarEmReal;
        decimal dolarParaEuro = dolarParaReal / taxaEuroEmReal;

        Console.WriteLine($"Valor em Dólar: $ {valor:N2}");
        Console.WriteLine($"Convertido para Real: {dolarParaReal:C}");
        Console.WriteLine($"Convertido para Euro: € {dolarParaEuro:N2}");
        break;

    case "3":
        decimal euroParaReal = valor * taxaEuroEmReal;
        decimal euroParaDolar = euroParaReal / taxaDolarEmReal;

        Console.WriteLine($"Valor em Euro: € {valor:N2}");
        Console.WriteLine($"Convertido para Real: {euroParaReal:C}");
        Console.WriteLine($"Convertido para Dólar: $ {euroParaDolar:N2}");
        break;

    default:
        Console.WriteLine("Opção de moeda inválida.");
        break;
}

Console.WriteLine("------------------------------------------");