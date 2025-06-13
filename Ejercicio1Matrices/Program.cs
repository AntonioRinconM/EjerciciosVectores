using System.Net.Http.Headers;

namespace Ejemplo
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();
            const int MAXF = 3, MAXC = 5;
            int[,] Matriz = new int[MAXF, MAXC];
            int swap = 0;

            for (int filas=0; filas<MAXF; filas++)
            {
                for(int columnas=0; columnas<MAXC; columnas++)
                {
                    Matriz[filas, columnas] = random.Next(1, 100);
                }
            }

            Console.WriteLine("Matriz completa:");

            for (int filas = 0; filas < MAXF; filas++)
            { 
                Console.WriteLine(" ");
                for (int columnas=0; columnas<MAXC; columnas++)
                {
                    Console.Write($"{Matriz[filas,columnas]}|");
                }
            }

            Console.WriteLine("\n \nFila 2:");
            for(int i = 0;i < MAXC; i++)
            {
                Console.Write($"{Matriz[1,i]}|");
            }

            Console.WriteLine("\n\n Columna 3:");
            for(int i = 0; i < MAXF; i++)
            {
                Console.WriteLine($"|{Matriz[i,2]}|");
            }

            Console.WriteLine("\n\n Columna 1:");
            for (int i = 0; i < MAXF; i++)
            {
                Console.WriteLine($"|{Matriz[i, 0]}|");
            }

            Console.WriteLine("\n\n Columna 1 re-ordenada de menor a mayor:");
            for(int i=0; i<MAXF; i++)
            {
                for(int j=i+1; j<MAXF; j++)
                {
                    if (Matriz[i, 0] > Matriz[j, 0])
                    {
                        swap=Matriz[i, 0];
                        Matriz[i,0]=Matriz[j,0];
                        Matriz[j, 0] = swap;
                    }
                }
            }

            for (int i = 0; i < MAXF; i++)
            {
                Console.WriteLine($"|{Matriz[i, 0]}|");
            }
        }
    }
}