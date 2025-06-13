namespace TpVectAct1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int[10];
            int total=0, promedio=0;

            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero Nro{i+1}");
                Numeros[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < Numeros.Length;i++)
            {
                total += Numeros[i];
            }

            promedio = total / Numeros.Length;

            Console.WriteLine($"El total de los numeros ingresados es : {total}");
            Console.WriteLine($"Y el promedio es: {promedio}");

        }
    }
}
