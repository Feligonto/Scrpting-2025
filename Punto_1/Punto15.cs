//15 (funciones)

class Punto15
{
    public static void Palindromo(string[] args)
    {
        Console.WriteLine("\nVerificación de Palíndromos");
        Console.Write("Anita lava la tina: ");
        Console.Write(EsPalindromo("Anita lava la tina"));        // True
        Console.Write("\nA mamá Roma le aviva el amor a mamá: ");
        Console.Write(EsPalindromo("\nA mamá Roma le aviva el amor a mamá")); // True
        Console.Write("\nHola mundo: ");
        Console.Write(EsPalindromo("\nHola mundo"));                // False
        Console.Write("\nLuz azul: ");
        Console.Write(EsPalindromo("\nLuz azul"));                  // True
        Console.Write("\nYo hago yoga hoy: ");
        Console.Write(EsPalindromo("\nYo hago yoga hoy"));         // True
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
        texto = texto.Replace("á", "a")
                     .Replace("é", "e")
                     .Replace("í", "i")
                     .Replace("ó", "o")
                     .Replace("ú", "u")
                     .Replace("ü", "u")
                     .Replace("ñ", "n");

        texto = System.Text.RegularExpressions.Regex.Replace(texto, @"[^a-zA-Z0-9]", "");

        return texto.ToLower();
    }
}