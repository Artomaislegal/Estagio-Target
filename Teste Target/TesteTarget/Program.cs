using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
    var Indice = 13;
    var Soma = 0;
    var K = 0;
    while(K < Indice)
    {
        K = K + 1;
        Soma = Soma + K;
    }
    Console.WriteLine($"O valor da soma será de: {Soma}");
    }
}
