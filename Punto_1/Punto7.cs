 //7 (Cadenas)
class Punto7
{
    public static void CadenaArreglo(string[] args)
    {
        Console.Write("Ingresa una cadena de números enteros positivos separados por espacios: ");
        string entrada = Console.ReadLine();

        string[] partes = entrada.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int[] numeros = new int[partes.Length];
        bool entradaValida = true;

        for (int i = 0; i < partes.Length; i++)
        {
            if (int.TryParse(partes[i], out int valor) && valor > 0)
            {
                numeros[i] = valor;
            }
            else
            {
                entradaValida = false;
                Console.WriteLine("Error: '"+ partes[i] +"' no es un número entero positivo.");
                break;
            }
        }

        if (entradaValida)
        {
            Console.WriteLine("Array de números:");
            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("La cadena contenía valores inválidos. Intenta de nuevo.");
        }
    }
}

