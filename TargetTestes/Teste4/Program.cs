var faturamentoPorEstado = new Dictionary<string, double>  // Criando um dicionário com os dados
{
    { "SP", 67836.43 },
    { "RJ", 36678.66 },
    { "MG", 29229.88 },
    { "ES", 27165.48 },
    { "Outros", 19849.53 }
};

double valorTotal = 0;
foreach (var valor in faturamentoPorEstado.Values)      // Passamos por todos os valores (Values) somando o valor de faturamento respectivo no valor total
{
    valorTotal += valor;
}

Console.WriteLine("Percentual de representação por estado:");
foreach (var estado in faturamentoPorEstado.Keys)       // Passamos por todos os estados (Keys) e fazemos os cálculos
{
    double valor = faturamentoPorEstado[estado];        // Pegamos o valor de faturamento do estado respectivo
    double percentual = (valor / valorTotal) * 100;     // Calculamos a porcentagem dividindo o valor dele pelo valor total e *100 para ficar em porcentagem
    Console.WriteLine($"{estado}: {percentual:F2}%");   // Escrevemos a porcentagem deixando somente 2 números depois da vírgula
}