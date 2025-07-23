//2 (arreglos)

class Punto2
{
    public static void PromedioPos(string[] args)
    {
        float[] numeros = { -1.5f, 3.2f, 0f, 7.8f, -4.6f, 5.0f };
        Console.Write("Arreglo de números: ");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i] + " ");
        }
        

        float promedio = CalcularPromedioPositivos(numeros);

        Console.WriteLine($"\nEl promedio de los números positivos es: {promedio}\n");
    }

    static float CalcularPromedioPositivos(float[] numeros)
    {
        float[] positivos = numeros.Where(n => n > 0).ToArray();

        if (positivos.Length == 0)
        {
            Console.WriteLine("No hay números positivos en el arreglo.");
            return 0;
        }

        float suma = positivos.Sum();
        return suma / positivos.Length;
    }
}

