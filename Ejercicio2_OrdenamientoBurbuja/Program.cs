using System.Numerics;

namespace TpVectAtc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int[5];
            int Swap;

            

            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el valor Nro.{i+1}");
                Numeros[i] = int.Parse( Console.ReadLine() );
            }  

            for (int i = 0;i < Numeros.Length; i++)
            {
                for (int j = i+1 ; j < Numeros.Length; j++)
                {
                    if(Numeros[i] > Numeros[j])
                    {
                        Swap = Numeros[i];
                        Numeros[i]=Numeros[j];
                        Numeros[j]=Swap;
                    }
                }
            }

            Console.WriteLine("Vector ordenado:");
            for (int i = 0;i <Numeros.Length;i++)
            {
                Console.Write($"{Numeros[i]} ");
            }
        }
    }
}
