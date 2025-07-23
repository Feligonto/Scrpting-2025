//6 (ciclos)

class Punto6
{
    public static void SumaImpar(string[] args)
    {
        Console.Write("Ingresa la cantidad de números impares que deseas sumar: ");
        int n = int.Parse(Console.ReadLine());

        int contador = 0;
        int numero = 1;
        int suma = 0;

        do
        {
            suma += numero;
            numero += 2;
            contador++;
        }
        while (contador < n);

        Console.WriteLine("La suma de los primeros " + n + " números impares es: " + suma + "\n");
    }
}

