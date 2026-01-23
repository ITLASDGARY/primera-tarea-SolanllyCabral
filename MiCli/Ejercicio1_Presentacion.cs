namespace MiCli;

// TODO: Crea un programa que imprima tu Nombre, Carrera y Hobby favorito en líneas separadas
public class Ejercicio1_Presentacion
{
    public static string ObtenerPresentacion()
    {
        // TODO: Declara tres variables string: nombre, carrera y hobby
        string nombre = "Solanlly María Cabral Sánchez";
        string carrera = "Ingeniería en Software";
        string hobby = "Ver películas y series";
        // TODO: Retorna un string con las tres variables en líneas separadas
        return $"Mi nombre es: {nombre}\n" +
        $"Mi carrera es: {carrera}\n" +
        $"Mi hobby es: {hobby}"; //OJO: reemplaza este texto
        throw new NotImplementedException();
    }
    
    public static void Ejecutar()
    {
        Console.WriteLine(ObtenerPresentacion());
    }
}
