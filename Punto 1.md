# 1

Realizar cinco programas y responda dos preguntas de teoría, se debe usar C# como lenguaje de Programación, click en el enlace para realizar la autoasignación de los enunciados

[**Enunciados**](https://docs.google.com/document/d/1yT7-HVfscZ_biObi1HarsSORy2PruXnnH0Xnzbzr9IE/edit?usp=sharing)

### Ejercicios seleccionados

- 15 (funciones)

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(EsPalindromo("Anita lava la tina"));        // True
        Console.WriteLine(EsPalindromo("A mamá Roma le aviva el amor a mamá")); // True
        Console.WriteLine(EsPalindromo("Hola mundo"));                // False
        Console.WriteLine(EsPalindromo("Luz azul"));                  // True
        Console.WriteLine(EsPalindromo("Yo hago yoga hoy"));         // True
    }

    static bool EsPalindromo(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto))
            return false;

        string limpio = QuitarTildesYPuntuacion(texto.ToLower());

        for (int i = 0; i < limpio.Length / 2; i++)
        {
            if (limpio[i] != limpio[limpio.Length - 1 - i])
                return false;
        }

        return true;
    }

    static string QuitarTildesYPuntuacion(string texto)
    {
        string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();

        foreach (char c in textoNormalizado)
        {
            var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);

            if (unicodeCategory != UnicodeCategory.NonSpacingMark && Char.IsLetterOrDigit(c))
            {
                sb.Append(c);
            }
        }

        return sb.ToString().Normalize(NormalizationForm.FormC);
    }
}

- 18 (funciones)

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número de hasta 8 cifras: ");
        string entrada = Console.ReadLine();

        if (!EsNumeroValido(entrada))
        {
            Console.WriteLine("Entrada inválida. Asegúrate de ingresar un número de hasta 8 dígitos.");
            return;
        }

        int numero = int.Parse(entrada);
        int resultado = ReducirADigito(numero);

        Console.WriteLine($"El resultado final es: {resultado}");
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

- 2 (arreglos)

class Program
{
    static void Main(string[] args)
    {
        float[] numeros = { -1.5f, 3.2f, 0f, 7.8f, -4.6f, 5.0f };

        float promedio = CalcularPromedioPositivos(numeros);

        Console.WriteLine($"El promedio de los números positivos es: {promedio}");
    }

    static float CalcularPromedioPositivos(float[] arreglo)
    {
        var positivos = arreglo.Where(n => n > 0).ToArray();

        if (positivos.Length == 0)
        {
            Console.WriteLine("No hay números positivos en el arreglo.");
            return 0;
        }

        float suma = positivos.Sum();
        return suma / positivos.Length;
    }
}

- 6 (ciclos)

class Program
{
    static void Main(string[] args)
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

        Console.WriteLine($"La suma de los primeros {n} números impares es: {suma}");
    }
}

- 7 (Cadenas)

class Program
{
    static void Main(string[] args)
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
                Console.WriteLine($"Error: '{partes[i]}' no es un número entero positivo.");
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

## Preguntas de teoria:

#### 1. ¿Cuál es la diferencia entre la longitud de un array y la de una cadena?

La diferencia entre la longitud de un array y la de una cadena está principalmente en qué representan y cómo se miden, aunque ambos conceptos se refieren al número de elementos que contienen.

- **Array (arreglo):** Es una estructura de datos que almacena múltiples valores (números, cadenas, objetos, etc.) en posiciones indexadas.
Longitud: representa la cantidad de elementos que contiene.
- Ejemplo en C#:

```cs
int[] numeros = {1, 2, 3, 4};
Console.WriteLine(numeros.Length);  // Output: 4
```
- **Cadena (String):** Es una secuencia de caracteres.
Longitud: representa el número de caracteres en la cadena (incluyendo espacios, signos de puntuación, etc.).
- Ejemplo en C#:

```cs
string saludo = "Hola";
Console.WriteLine(saludo.Length);  // Output: 4
```

#### 2. ¿Qué es un error en tiempo de ejecución? escriba un ejemplo.
Un error en tiempo de ejecución es un error que ocurre mientras se está ejecutando un programa, es decir, después de que ha sido compilado correctamente (en lenguajes compilados como C#).

##### Errores comunes en tiempos de ejecución:
- División por cero
- Acceso a un índice fuera del rango de un array
- Uso de una variable null o no inicializada
- Problemas de conversión de tipos

Estos errores no se detectan durante la compilación, sino que aparecen cuando el programa está en funcionamiento, y suelen causar que el programa se detenga inesperadamente.

```cs
int a = 10;
int b = 0;
int resultado = a / b;  // Error en tiempo de ejecución: división por cero.
Console.WriteLine("Resultado: " + resultado);
```
