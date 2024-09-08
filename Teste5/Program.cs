Console.WriteLine("Digite uma string para inverter:");
string? normal = Console.ReadLine();    // Pegamos a string que o usuário deseja inverter
var invertida = "";                     // Variável para a string invertida

if (normal == "")  // Verificar se a string é nula
{
    Console.WriteLine("A string não pode ser invertida pois não há o que inverter");
}
else  // Caso não seja nula
{
    for (var i = normal!.Length - 1; i >= 0; i--) // Entramos nesse for que faz uma variável i ter o valor do tamanho da string que o usuário quer inverter e vamos reduzindo
    {
        invertida += normal[i]; // Conforme reduzimos vamos adicionando na lista invertida de modo que o último caractere fique em primeiro nessa lista e assim por diante
    }
    Console.WriteLine($"String invertida: {invertida}");  // Resultado
}

