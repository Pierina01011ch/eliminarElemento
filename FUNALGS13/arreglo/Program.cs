using arreglo;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño del arreglo: ");
        int n = int.Parse(Console.ReadLine());

        Arreglo arreglo = new Arreglo(n);

        Console.WriteLine("Ingrese los valores del arreglo:");
        arreglo.LlenarArreglo();

        Console.WriteLine("\nArreglo original:");
        arreglo.MostrarArreglo();

        Console.Write("\nFavor de ingresar la posición del elemento a eliminar (empezando desde 0): ");
        int posicion = int.Parse(Console.ReadLine());

        arreglo.EliminarElemento(posicion);

        Console.WriteLine("\nArreglo después de la eliminación:");
        arreglo.MostrarArreglo();
    }
}

