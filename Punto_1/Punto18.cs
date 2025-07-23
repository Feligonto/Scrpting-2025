//18 (funciones)

class Punto18
{
    public static void SumaCifras(string[] args)
    {
        Console.Write("\n\nIngresa un número de hasta 8 cifras: ");
        string entrada = Console.ReadLine();

        if (!EsNumeroValido(entrada))
        {
            Console.WriteLine("Entrada inválida. Asegúrate de ingresar un número de hasta 8 dígitos.");
            return;
        }

        int numero = int.Parse(entrada);
        int resultado = ReducirADigito(numero);

        Console.WriteLine("El resultado final es: " + resultado);
    }

    static bool EsNumeroValido(string entrada)
    {
        return int.TryParse(entrada, out int num) && entrada.Length <= 8 && num >= 0;
    }

    static int ReducirADigito(int numero)
    {
        while (numero >= 10)
        {
            numero = SumarDigitos(numero);
        }

        return numero;
    }

    static int SumarDigitos(int numero)
    {
        int suma = 0;

        while (numero > 0)
        {
            suma += numero % 10;
            numero /= 10;
        }

        return suma;
    }
}

