namespace MiCli;

// TODO: Declara una constante e intenta cambiar su valor para ver el error
public class Ejercicio3_ErrorIntencional
{
    public static string UsarConstanteCorrectamente()
    {
        // TODO: Declara una constante int
        const double pi = 3.1416;
        // TODO: Intenta cambiar su valor en la siguiente línea (esto causará un error)
        //pi = 3.15;
        // TODO: Lee el error que te da Visual Studio
        // TODO: Comenta la línea que causa el error
        // TODO: Retorna un mensaje con el valor de la constante
        return $"El valor de la constante es: {pi}"; //OJO: reemplaza este texto
        throw new NotImplementedException();
    }
    
    public static void Ejecutar()
    {
        Console.WriteLine(UsarConstanteCorrectamente());
    }
}
