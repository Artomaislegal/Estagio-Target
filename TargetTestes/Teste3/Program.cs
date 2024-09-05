// Decisão do porque fazer com dicionário: Primeiramente porque é um dos últimos conceitos de programação que eu aprendi na faculdade
// que eu utilizei em um trabalho de Linguagens Formais e Autômatos.
// O porquê de usar dicionário é porque como queremos armazenar os dias e os valores a sintaxe do dicionário que, armazena uma Chave e um Valor
// acaba combinando perfeitamente com o que é proposto no exercício, por outro lado isso também pode ser resolvido com uma lista
// ou até mesmo uma lista de dicionário se quisermos armazenar dia(Lista) 1(Dicionário) Valor(Lista) 1000(Dicionário)
// mas essa última solução acaba pecando em performance sem adicionar algo útil

var faturamentoDiario = new Dictionary<int, double>  // Criando o Dicionário
{
    {1, 22174.1664},
    {2, 24537.6698},
    {3, 26139.6134},
    {4, 0.0},
    {5, 0.0},
    {6, 26742.6612},
    {7, 0.0},
    {8, 42889.2258},
    {9, 46251.174},
    {10, 11191.4722},
    {11, 0.0},
    {12, 0.0},
    {13, 3847.4823},
    {14, 373.7838},
    {15, 2659.7563},
    {16, 48924.2448},
    {17, 18419.2614},
    {18, 0.0},
    {19, 0.0},
    {20, 35240.1826},
    {21, 43829.1667},
    {22, 18235.6852},
    {23, 4355.0662},
    {24, 13327.1025},
    {25, 0.0},
    {26, 0.0},
    {27, 25681.8318},
    {28, 1718.1221},
    {29, 13220.495},
    {30, 8414.61}
};
var diasComFaturamento = faturamentoDiario.Where(x => x.Value > 0).ToList();    // Retirando os dias com faturamento = 0, conforme pedido
double menorFaturamento = diasComFaturamento.Min(x => x.Value);                 // Menor Faturamento
double maiorFaturamento = diasComFaturamento.Max(x => x.Value);                 // Maior Faturamento
double mediaFaturamento = diasComFaturamento.Average(x => x.Value);             // Média do faturamento
int diasAcimaMedia = diasComFaturamento.Count(x => x.Value > mediaFaturamento); // Dias com faturamento acima da média

Console.WriteLine($"Menor valor de faturamento: {menorFaturamento:F2}");
Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento:F2}");
Console.WriteLine($"Número de dias com faturamento superior à média: {diasAcimaMedia}");