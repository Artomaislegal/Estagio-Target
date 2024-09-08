int numero = 0;
Console.Write("Informe um número: ");
while (!int.TryParse(Console.ReadLine(), out numero))  // Este while está ai só para o usuário não conseguir colocar nada
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

static bool PertenceFibonacci(int numero)  // Fazendo um método só para mostrar que eu sei sobre métodos
{
    int a = 0;
    int b = 1;

    if (numero == a || numero == b) // Verifico se o número desejado não é igual a alguns do números iniciais 0 ou 1
    {
        return true;                // Se for igual já está resolvido
    }

    int c = a + b;
    while (c <= numero)             // Enquanto a soma for menor ou igual ao número desejado repito o seguinte passo
    {
        if (c == numero)            // Caso seja igual volto verdadeiro
        {
            return true;
        }

        a = b;
        b = c;
        c = a + b;                  // Vou passando os números adiante seguindo a ordem da regra de Fibonacci
    }

    return false;                   // Retorno falso se o número não pertencer a regra
}