using System;

namespace potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el exponente: ");
            int exponente = int.Parse(Console.ReadLine());

            int resultado = 1; // Inicio con 1 porque cualquier numero elevado a 0 es 1.

            if (exponente < 0)
            {
                Console.WriteLine("El programa solo maneja exponentes positivos.");
                return;
            }

            for (int i = 0; i < exponente; i++)
            {
                resultado *= baseNum; 
            }

            Console.WriteLine($"La potencia es {resultado}");
            Console.ReadKey(); 
        }
    }
}