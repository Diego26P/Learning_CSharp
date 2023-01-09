using Internal;
using System;

class Principal {
    static void Main() {

        int numA = 0, numB = 0;

        Console.Write("\n Número: ");
        numA = int.Parse(Console.ReadLine());

        Console.Write("\n Número Dois: ");
        numB = int.Parse(Console.ReadLine());

        Console.WriteLine("\nSoma: "+ (numA + numB));
        Console.WriteLine("Subtração: "+ (numA - numB));
        Console.WriteLine("Multiplicação: "+ (numA * numB));
        Console.WriteLine("Divisão: "+ (numA / numB));
    }
}