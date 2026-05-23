using Dsw2026Ej11.Domain;
using Dsw2026Ej11.Collections;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList caso = new CasoList();

        // CREO Y AGREGO ALUMNOS

        var alumno1 = new Alumno(1, "Juan", 8.5);
        var alumno2 = new Alumno(2, "Maria", 9.0);
        var alumno3 = new Alumno(3, "Pedro", 7.5);

        caso.AgregarAlumno(alumno1);
        caso.AgregarAlumno(alumno2);
        caso.AgregarAlumno(alumno3);

        /// MUESTRO POR CONSOLA

        Console.WriteLine("ALUMNOS:");
        var alumnosListado = caso.ObtenerAlumnos();
        if (alumnosListado != null)
        {
            foreach (var item in alumnosListado)
            {
                Console.WriteLine(item);
            }
        }

        // BUSCAMOS ALUMNO EXISTENTE POR NOMBRE Y MOSTRAMOS POR CONSOLA
        Console.WriteLine("\nBUSQUEDA POR ALUMNO EXISTENTE:");
        var alumnoExiste = caso.ObtenerAlumnoPorNombre("Maria");
        if (alumnoExiste != null)
        {
            Console.WriteLine($"ALUMNO ENCONTRADO: {alumnoExiste}");
        }
        else
        {
            Console.WriteLine("No existe");
        }

        // BUSCAMOS ALUMNO NO EXISTENTE POR NOMBRE Y MOSTRAMOS POR CONSOLA

        Console.WriteLine("\nBUSQUEDA POR ALUMNO NO EXISTENTE:");
        var alumnoNoExiste = caso.ObtenerAlumnoPorNombre("Carlos");
        if (alumnoNoExiste != null)
        {
            Console.WriteLine($"ALUMNO ENCONTRADO: {alumnoNoExiste}");
        }
        else
        {
            Console.WriteLine("No existe");
        }

        // ELIMINAMOS UN ALUMNO Y MOSTRAMOS POR CONSOLA
        Console.WriteLine("\nELIMINAMOS ALUMNO MARIA:");
        caso.EliminarAlumno(alumno2);
        alumnosListado = caso.ObtenerAlumnos();
        if (alumnosListado != null)
        {
            foreach (var item in alumnosListado)
            {
                Console.WriteLine(item);
            }
        }

        //ELIMINAMOS EL PRIMER ELEMENTO DE LA LISTA Y MOSTRAMOS POR CONSOLA
        Console.WriteLine("\nELIMINAMOS EL PRIMER ELEMENTO DE LA LISTA:");
        caso.EliminarAlumnoPorPosicion(0);
        alumnosListado = caso.ObtenerAlumnos();
        if (alumnosListado != null)
        {
            foreach (var item in alumnosListado)
            {
                Console.WriteLine(item);
            }
        }
    }
    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary caso = new CasoDictionary();

        // CREO Y AGREGO ALUMNOS

        var alumno1 = new Alumno(1, "Juan", 8.5);
        var alumno2 = new Alumno(2, "Maria", 9.0);
        var alumno3 = new Alumno(3, "Pedro", 7.5);

        caso.AgregarAlumno(alumno1);
        caso.AgregarAlumno(alumno2);
        caso.AgregarAlumno(alumno3);

        /// MUESTRO POR CONSOLA
        Console.WriteLine("ALUMNOS:");
        var alumnosListado = caso.ObtenerAlumnos();
        if (alumnosListado != null)
        {
            foreach (var item in alumnosListado)
            {
                Console.WriteLine(item.Value);
            }
        }

        // BUSCAMOS ALUMNO EXISTENTE POR CLAVE Y MOSTRAMOS POR CONSOLA

        Console.WriteLine("\nBUSQUEDA POR ALUMNO EXISTENTE:");

        var alumnoExiste = caso.ObtenerAlumnoPorClave(2);
        if (alumnoExiste != null)
        {
            Console.WriteLine($"ALUMNO ENCONTRADO: {alumnoExiste}");
        }
        else
        {
            Console.WriteLine("No existe");
        }

        // BUSCAMOS ALUMNO NO EXISTENTE POR CLAVE Y MOSTRAMOS POR CONSOLA

        Console.WriteLine("\nBUSQUEDA POR ALUMNO NO EXISTENTE:");

        var alumnoNoExiste = caso.ObtenerAlumnoPorClave(4);
        if (alumnoNoExiste != null)
        {
            Console.WriteLine($"ALUMNO ENCONTRADO: {alumnoNoExiste}");
        }
        else
        {
            Console.WriteLine("No existe");
        }

        // ELIMINAMOS UN ALUMNO POR CLAVE Y MOSTRAMOS POR CONSOLA

        Console.WriteLine("\nELIMINAMOS ALUMNO CON CLAVE 2:");
        caso.EliminarAlumnoPorClave(2);
        alumnosListado = caso.ObtenerAlumnos();
        if (alumnosListado != null)
        {
            foreach (var item in alumnosListado)
            {
                Console.WriteLine(item.Value);
            }
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        Console.WriteLine("\nEJEMPLO LINQ:\n");

        // METODO 1
        Console.WriteLine("1) - OBTENER EL PRIMER LIBRO\n");
        var primerLibro = CasoLinq.GetPrimero(Libro.CrearLista());
        if (primerLibro != null)
        {
            Console.WriteLine(primerLibro);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        // METODO 2
        Console.WriteLine("\n2) - OBTENER EL ULTIMO LIBRO\n");
        var ultimoLibro = CasoLinq.GetUltimo(Libro.CrearLista());
        if (ultimoLibro != null)
        {
            Console.WriteLine(ultimoLibro);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        // METODO 3
        Console.WriteLine("\n3) - OBTENER LA SUMA DE PRECIOS\n");
        var sumaPrecios = CasoLinq.GetTotalPrecios(Libro.CrearLista());
        Console.WriteLine($"SUMA DE PRECIOS: {sumaPrecios:C}");

        // METODO 4
        Console.WriteLine("\n4) - OBTENER EL PROMEDIO DE PRECIOS\n");
        var promedioPrecios = CasoLinq.GetPromedioPrecios(Libro.CrearLista());
        Console.WriteLine($"PROMEDIO DE PRECIOS: {promedioPrecios:C}");

        // METODO 5
        Console.WriteLine("\n5) - OBTENER LA LISTA DE LIBROS CON ID MAYOR A 15\n");
        var librosIdMayor15 = CasoLinq.GetListById(Libro.CrearLista());
        if (librosIdMayor15 != null)
        {
            foreach (var libro in librosIdMayor15)
            {
                Console.WriteLine(libro);
            }
        }
        else
        {
            Console.WriteLine("No existen libros con ID mayor a 15");
        }

        // METODO 6
        Console.WriteLine("\n6) - OBTENER UNA LISTA DE CADA LIBRO CON SU TÍTULO Y PRECIO EN FORMATO MONEDA\n");
        var listaLibrosConFormato = CasoLinq.GetLibros(Libro.CrearLista());
        foreach (var libro in listaLibrosConFormato)
        {
            Console.WriteLine(libro);
        }

        // METODO 7
        Console.WriteLine("\n7) - OBTENER EL LIBRO CON EL PRECIO MAS ALTO\n");
        var libroMayorPrecio = CasoLinq.GetMayorPrecio(Libro.CrearLista());
        Console.WriteLine($"\nEL LIBRO CON EL PRECIO MAS ALTO ES: {libroMayorPrecio}");

        // METODO 8
        Console.WriteLine("\n8) - OBTENER EL LIBRO CON EL PRECIO MAS BAJO\n");
        var libroMenorPrecio = CasoLinq.GetMenorPrecio(Libro.CrearLista());
        Console.WriteLine($"\nEL LIBRO CON EL PRECIO MAS BAJO ES: {libroMenorPrecio}");

        // METODO 9
        Console.WriteLine("\n9) - OBTENER LOS LIBROS CUYO PRECIO SEA MAYOR AL PROMEDIO\n");
        var librosMayorPromedio = CasoLinq.GetMayorPromedio(Libro.CrearLista());
        if (librosMayorPromedio != null)
        {
            foreach (var libro in librosMayorPromedio)
            {
                Console.WriteLine(libro);
            }
        }
        else
        {
            Console.WriteLine("No existen libros con precio mayor al promedio");
        }

        // METODO 10
        Console.WriteLine("\n10) - OBTENER LOS LIBROS ORDENADOS POR TÍTULO DE FORMA DESCENDENTE\n");
        var librosOrdenados = CasoLinq.GetLibrosOrdenados(Libro.CrearLista());
        if (librosOrdenados != null)
        {
            foreach (var libro in librosOrdenados)
            {
                Console.WriteLine(libro);
            }
        }
        else
        {
            Console.WriteLine("No existen libros para ordenar");
        }

    }
}
