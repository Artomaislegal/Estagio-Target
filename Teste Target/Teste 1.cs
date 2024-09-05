/*
Teste 2
class Program
{
    static void Main()
    {
        int numero = 0;
        Console.Write("Informe um número: ");
        while(!int.TryParse(Console.ReadLine(), out numero)) // Este while está ai só para o usuário não conseguir colocar nada
        {
            Console.Write("Coloque um número válido: ");
        }

        if (PertenceFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceFibonacci(int numero) // Fazendo um método só para mostrar que eu sei sobre métodos
    {
        int a = 0;
        int b = 1;

        if (numero == a || numero == b) // Verifico se o número desejado não é igual a alguns do números iniciais 0 ou 1
        {
            return true; // Se for igual já está resolvido
        }

        int c = a + b;
        while (c <= numero) // Enquanto a soma for menor ou igual ao número desejado repito o seguinte passo
        {
            if (c == numero) // Caso seja igual volto verdadeiro
            {
                return true;
            }

            a = b;
            b = c;
            c = a + b; // Vou passando os números adiante seguindo a ordem da regra de Fibonacci
        }

        return false; // Retorno falso se o número não pertencer a regra
    }
}

Teste 3
class Program
{
    static void Main()
    {
        // Decisão do porque fazer com dicionário: Primeiramente porque é um dos últimos conceitos de programação que eu aprendi na faculdade
        // que eu utilizei em um trabalho de Linguagens Formais e Autômatos.
        // O porquê de usar dicionário é porque como queremos armazenar os dias e os valores a sintaxe do dicionário que, armazena uma Chave e um Valor
        // acaba combinando perfeitamente com o que é proposto no exercício, por outro lado isso também pode ser resolvido com uma lista
        // ou até mesmo uma lista de dicionário se quisermos armazenar dia(Lista) 1(Dicionário) Valor(Lista) 1000(Dicionário)
        // mas essa última solução acaba pecando em performance sem adicionar algo útil
        var faturamentoDiario = new Dictionary<int, double> // Criando o Dicionário
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
    }
}
Teste 4
class Program
{
    static void Main()
    {
        var faturamentoPorEstado = new Dictionary<string,double> // Criando um dicionário com os dados
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        double valorTotal = 0;
        foreach (var valor in faturamentoPorEstado.Values) // Passamos por todos os valores (Values) somando o valor de faturamento respectivo no valor total
        {
            valorTotal += valor;
        }

        Console.WriteLine("Percentual de representação por estado:");
        foreach (var estado in faturamentoPorEstado.Keys) // Passamos por todos os estados (Keys) e fazemos os cálculos
        {
            double valor = faturamentoPorEstado[estado];        // Pegamos o valor de faturamento do estado respectivo
            double percentual = (valor / valorTotal) * 100;     // Calculamos a porcentagem dividindo o valor dele pelo valor total e *100 para ficar em porcentagem
            Console.WriteLine($"{estado}: {percentual:F2}%");   // Escrevemos a porcentagem deixando somente 2 números depois da vírgula
        }
    }
}  
Teste 5
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma string para inverter:");
        string? normal = Console.ReadLine(); // Pegamos a string que o usuário deseja inverter
        var invertida = ""; // Variável para a string invertida

        if (normal == null) // Verificar se a string é nula
        {
            Console.WriteLine("A string não pode ser invertida pois ela é nula");
        }
        else // Caso não seja nula
        {
            for (var i = normal.Length - 1; i >= 0; i--) // Entramos nesse for que faz uma variável i ter o valor do tamanho da string que o usuário quer inverter e vamos reduzindo
            {
                invertida += normal[i]; // Conforme reduzimos vamos adicionando na lista invertida de modo que o último caractere fique em primeiro nessa lista e assim por diante
            }
        }
        
        Console.WriteLine($"String invertida: {invertida}"); // Resultado
    }
}
*/