using System;

namespace CompararMatrices
{
    public class Matrices
    {
        public void CompararMatrices()
        {
            try
            {
                // Solicitar la longitud de las matrices
                Console.WriteLine("Ingrese la longitud de las matrices:");
                int longitud = int.Parse(Console.ReadLine());

                // Crear dos matrices de la longitud especificada
                int[] matriz1 = new int[longitud];
                int[] matriz2 = new int[longitud];

                // Leer la primera matriz desde la consola
                Console.WriteLine("Ingrese los elementos de la primera matriz:");
                for (int i = 0; i < longitud; i++)
                {
                    Console.Write($"Elemento {i + 1}: ");
                    matriz1[i] = int.Parse(Console.ReadLine());
                }

                // Leer la segunda matriz desde la consola
                Console.WriteLine("Ingrese los elementos de la segunda matriz:");
                for (int i = 0; i < longitud; i++)
                {
                    Console.Write($"Elemento {i + 1}: ");
                    matriz2[i] = int.Parse(Console.ReadLine());
                }

                // Comparar las dos matrices
                bool sonIguales = true;
                for (int i = 0; i < longitud; i++)
                {
                    if (matriz1[i] != matriz2[i])
                    {
                        sonIguales = false;
                        break;
                    }
                }

                // Mostrar el resultado de la comparación
                if (sonIguales)
                {
                    Console.WriteLine("Las matrices son iguales.");
                }
                else
                {
                    Console.WriteLine("Las matrices no son iguales.");
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y muestra un mensaje de error
                Console.WriteLine("Ocurrió un error durante la ejecución del programa: " + ex.Message);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Matrices y llamar al método CompararMatrices
            Matrices matrices = new Matrices();
            matrices.CompararMatrices();
        }
    }
}
