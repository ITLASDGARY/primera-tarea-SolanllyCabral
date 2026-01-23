namespace MiCli;

// TODO: Declara dos variables int con valores fijos, súmalas y muestra el resultado
public class Ejercicio2_Sumadora
{
    public static int Sumar(int a, int b)
    {
        // TODO: Implementa la suma de a y b
        return a + b; //OJO: reemplaza este texto con el resultado de la suma
        throw new NotImplementedException();
    }
    
    public static string ObtenerResultado()
    {
        // TODO: Declara dos variables int con valores fijos
        int a = 10;
        int b = 20;
        // TODO: Implementa la suma de a y b, y guarda el resultado
        int resultado = a + b;
        // TODO: Retorna el texto "La suma es: X" donde X es el resultado
        return $"La suma es: {resultado}"; //OJO: reemplaza este texto
        throw new NotImplementedException();
    }
    
    public static void Ejecutar()
    {
        Console.WriteLine(ObtenerResultado());
    }
}
