# 4

Realizar 20 firmas diferentes de funciones con sus respectivas invocaciones, se debe evidenciar diferentes variaciones de funciones, con parametros, sin parametros, con retorno, sin retorno, usar diferentes tipos de datos como clases, cadenas, matrices, etc,. Se debe entregar en un repositorio.

### **Desarrollo**

```cs
// 1.  Función sin parámetros ni retorno
static void Saludar()

// 2.  Función con parámetros y retorno (enteros)
static int Sumar(int a, int b)

// 3.  Función con cadena y array
static string ProcesarTexto(string texto, char[] caracteres)

// 4.  Función con retorno booleano
static bool EsPar(int num)

// 5.  Función con parámetro opcional
static int Potencia(int baseNum, int exponente = 2)

// 6.  Función con tupla como parámetro y retorno
static (int, int) Intercambiar((int x, int y) valores)

// 7.  Función con parámetro out
static bool TryParseInt(string input, out int resultado)

// 8.  Función con lista genérica
static List<int> FiltrarPares(List<int> numeros)

// 9.  Función con matriz bidimensional
static int SumarMatriz(int[,] matriz)

// 10.  Función con delegado como parámetro
static void ProcesarNumeros(int[] numeros, Action<int> accion)

// 11.  Función con diccionario
static void ActualizarInventario(Dictionary<string, int> inventario, string item, int cantidad)

// 12.  Función con parámetros params
static int SumarParams(params int[] numeros)

// 13.  Función que retorna un valor nulleable
static int? BuscarValor(int[] array, int valor)

// 14.  Función con objeto de clase personalizada
class Usuario

static void SaludarUsuario(Usuario usuario)

// 15.  Función genérica
static T ObtenerPrimero<T>(List<T> lista)

// 16.  Función con enumeración
enum Estado { Activo, Inactivo }

static string VerificarEstado(Estado estado)

// 17.  Función con parámetro de referencia (ref)
static void Duplicar(ref int numero)

// 18.  Función con parámetro in (solo lectura)
static double CalcularArea(in Circulo circulo)

// 19.  Función asíncrona (simplificada)
static async Task<string> ObtenerDatosAsync()

// 20.  Función con expresión lambda
static Func<int, int> Cubo = x => x * x * x;
```
