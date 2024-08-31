using System;
using System.Collections.Generic;

namespace Numeros
{
    public class AnalizadorNumeros
    {
        public void ProcesarNumeros()
        {
            try
            {
                Console.WriteLine("¿Cuántos números desea ingresar?");
                int n = int.Parse(Console.ReadLine());

                // Lista para almacenar los números ingresados
                List<int> numeros = new List<int>();

                // Ingresar los números
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Ingrese el número {i + 1}: ");
                    int numero = int.Parse(Console.ReadLine());
                    numeros.Add(numero);
                }

                // Determinar el menor valor
                int menorValor = int.MaxValue;
                foreach (int numero in numeros)
                {
                    if (numero < menorValor)
                    {
                        menorValor = numero;
                    }
                }

                // Verificar si algún valor se repite
                bool hayRepetidos = false;
                HashSet<int> numerosUnicos = new HashSet<int>();
                foreach (int numero in numeros)
                {
                    if (!numerosUnicos.Add(numero))
                    {
                        hayRepetidos = true;
                        break;
                    }
                }

                // Mostrar resultados
                Console.WriteLine($"\nEl menor valor ingresado es: {menorValor}");
                if (hayRepetidos)
                {
                    Console.WriteLine("Hay valores repetidos.");
                }
                else
                {
                    Console.WriteLine("No hay valores repetidos.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AnalizadorNumeros analizador = new AnalizadorNumeros();
            analizador.ProcesarNumeros();
        }
    }
}
