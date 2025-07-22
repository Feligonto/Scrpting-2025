# 4

Realizar 20 firmas diferentes de funciones con sus respectivas invocaciones, se debe evidenciar diferentes variaciones de funciones, con parametros, sin parametros, con retorno, sin retorno, usar diferentes tipos de datos como clases, cadenas, matrices, etc,. Se debe entregar en un repositorio.

### **Desarrollo**

1.  `static void Saludar()`
Función sin parámetros ni retorno
2.  `static int Sumar(int a, int b)`
Función con parámetros y retorno (enteros)
3.  `static string ProcesarTexto(string texto, char[] caracteres)`
Función con cadena y array
4.  `static bool EsPar(int num)`
Función con retorno booleano
5.  `static int Potencia(int baseNum, int exponente = 2)`
Función con parámetro opcional
6.  `static (int, int) Intercambiar((int x, int y) valores)`
Función con tupla como parámetro y retorno
7.  `static bool TryParseInt(string input, out int resultado)`
Función con parámetro out
8.  `static List<int> FiltrarPares(List<int> numeros)`
Función con lista genérica
9.  `static int SumarMatriz(int[,] matriz)`
Función con matriz bidimensional
10.  `static void ProcesarNumeros(int[] numeros, Action<int> accion)`
Función con delegado como parámetro
11.  `static void ActualizarInventario(Dictionary<string, int> inventario, string item, int cantidad)`
Función con diccionario
12.  `static int SumarParams(params int[] numeros)`
Función con parámetros params
13.  `static int? BuscarValor(int[] array, int valor)`
Función que retorna un valor nulleable
14.  `class Usuario` `static void SaludarUsuario(Usuario usuario)`
Función con objeto de clase personalizada
15.  `static T ObtenerPrimero<T>(List<T> lista)`
Función genérica
16.  `enum Estado { Activo, Inactivo }`  `static string VerificarEstado(Estado estado)`
Función con enumeración
17.  `static void Duplicar(ref int numero)`
Función con parámetro de referencia (ref)
18.  `static double CalcularArea(in Circulo circulo)`
Función con parámetro in (solo lectura)
19.  `static async Task<string> ObtenerDatosAsync()`
Función asíncrona (simplificada)
20.  `static Func<int, int> Cubo = x => x * x * x;`
Función con expresión lambda
