
namespace TpVectAct3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int[8];
            bool[] YaContado = new bool[8];
            int CantRep = 0;

            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}: ");
                Numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < Numeros.Length; i++)
            { 
                CantRep = 1;
                if (YaContado[i]==false)
                {
                    for (int j = i + 1; j < Numeros.Length; j++)
                    {
                        if (Numeros[i] == Numeros[j])
                        {
                            CantRep++;
                            YaContado[j] = true;
                        }
                    }
                    if (CantRep > 1)
                    {
                        Console.WriteLine($"El numero {Numeros[i]} se repite {CantRep} veces.");
                    }
                }
            }
        }
    }
}
