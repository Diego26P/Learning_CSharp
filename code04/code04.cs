using Internal;
using System;

class Principal{
    static void Main() {
        int num = 0;

        Console.WriteLine("Número: ");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("Tábuada de "+ num);
        for (int i = 1; i < 11; i ++) {
            Console.Write("\n "+ (num*i));
        }
    }
}