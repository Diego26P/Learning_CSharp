using Internal;
using System;

class Principal{
    static void Main() {
        float num = 0;
        int cont = 0;
        float soma = 0;

        while (num != -1.1) {
            Console.WriteLine(" Digite -1.1 para parar");
            Console.Write(" Digite um número: ");
            num = float.Parse(Console.ReadLine());
            Console.Write("Digitado: "+ num);
            soma = soma + num;
            cont ++;

        }

        float media = soma / cont;

        Console.WriteLine(" Média dos números: "+ media);


    }
}