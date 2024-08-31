namespace MatrizMultiplicada
{
    public class Matriz
    {
        public void CrearMatriz()
        {
            try
            {
                // Crear una matriz de 20 elementos
                int[] matriz = new int[20];

                // Inicializar cada elemento con el valor del índice multiplicado por 5
                for (int i = 0; i < matriz.Length; i++)
                {
                    matriz[i] = i * 5;
                }

                // Imprimir los elementos de la matriz en la consola
                Console.WriteLine("Elementos de la matriz:");
                for (int i = 0; i < matriz.Length; i++)
                {
                    Console.WriteLine($"Índice {i}: {matriz[i]}");
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
            // Crear una instancia de la clase Matriz y llamar al método CrearMatriz
            Matriz matriz = new Matriz();
            matriz.CrearMatriz();
        }
    }
}