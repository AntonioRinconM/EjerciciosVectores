namespace TpMatrizAct2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const int MAXF = 4, MAXC = 4;
            int[,] Matriz = new int[MAXF, MAXC];
            int TotalValores=0, Promedio = 0, Swap=0;

            for (int filas = 0; filas < MAXF; filas++)
            {
                for (int columnas = 0; columnas < MAXC; columnas++)
                {
                    Matriz[filas, columnas] = random.Next(01, 100);
                }
            }

            Console.WriteLine(" Matriz completa:");

            for (int filas = 0; filas < MAXF; filas++)
            {
                Console.WriteLine(" ");
                for (int columnas = 0; columnas < MAXC; columnas++)
                {
                    Console.Write($" {Matriz[filas, columnas]} |");
                }
            }

            Console.WriteLine("\n\n Diagonal principal:");
            for (int i=0; i<MAXF; i++)
            {
                Console.Write($" {Matriz[i, i]} |");
            }

            Console.Write("\n\n");
            for (int i = 0; i < MAXC; i++)
            {
                TotalValores += Matriz[0, i];
            }
            Promedio = TotalValores / MAXC;
            TotalValores = 0;
            Console.Write($" Promedio primera fila: {Promedio}.");

            Console.Write("\n\n Elementos de la primera fila que superan el promedio:");
            for (int i = 0; i < MAXC; i++)
            {
                if (Matriz[0, i] > Promedio)
                {
                    Console.Write($" {Matriz[0, i]} ;");
                    TotalValores++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($" La cantidad de elementos que superaron el promedio fue de {TotalValores}");

            Console.WriteLine("\n\n Columna 4 re-ordenada de mayor a menor");
            for (int i = 0; i < MAXF; i++)
            {
                for (int j = i + 1; j < MAXF; j++)
                {
                    if (Matriz[i, 0] < Matriz[j, 0])
                    {
                        Swap = Matriz[i, 0];
                        Matriz[i, 0] = Matriz[j, 0];
                        Matriz[j, 0] = Swap;
                    }
                }
            }

            for (int i = 0; i < MAXF; i++)
            {
                Console.WriteLine($" | {Matriz[i, 3]} |");
            }
        }
    }
}
