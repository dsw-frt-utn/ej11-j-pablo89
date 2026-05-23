using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    public CasoLinq()
    {

    }

    // 1 OBTENER EL PRIMER LIBRO
    public static Libro? GetPrimero(List<Libro> libros)
    {
        return libros.FirstOrDefault();
    }

    // 2 OBTENER EL ULTIMO LIBRO
    public static Libro? GetUltimo(List<Libro> libros)
    {
        return libros.LastOrDefault();
    }

    // 3 OBTENER LA SUMA DE PRECIOS
    public static decimal GetTotalPrecios(List<Libro> libros)
    {
        return libros.Sum(libro => libro.Precio);
    }

    // 4 OBTENER EL PROMEDIO DE PRECIOS
    public static decimal GetPromedioPrecios(List<Libro> libros)
    {
        return libros.Average(libro => libro.Precio);
    }

    // 5 OBTENER LA LISTA DE LIBROS CON ID MAYOR A 15
    public static List<Libro> GetListById(List<Libro> libros)
    {
        return libros.Where(libro => libro.Id > 15).ToList();
    }

    // 6 OBTENER UNA LISTA DE CADA LIBRO CON SU TÍTULO Y PRECIO EN FORMATO MONEDA
    public static List<string> GetLibros(List<Libro> libros)
    {
        return libros.Select(libro => $"{libro.Titulo} - {libro.Precio:C}").ToList();
    }

    // 7 OBTENER EL LIBRO CON EL PRECIO MAS ALTO
    public static Libro? GetMayorPrecio(List<Libro> libros)
    {
        return libros.OrderByDescending(libro => libro.Precio).FirstOrDefault();
    }

    // 8 OBTENER EL LIBRO CON EL PRECIO MAS BAJO
    public static Libro? GetMenorPrecio(List<Libro> libros)
    {
        return libros.OrderBy(libro => libro.Precio).FirstOrDefault();
    }

    //9 OBTENER LOS LIBROS CUYO PRECIO SEA MAYOR AL PROMEDIO
    public static List<Libro>? GetMayorPromedio(List<Libro> libros)
    {
        var promedio = GetPromedioPrecios(libros);
        return libros.Where(libro => libro.Precio > promedio).ToList();
    }

    // 10 OBTENER LOS LIBROS ORDENADOS POR TÍTULO DE FORMA DESCENDENTE
    public static List<Libro>? GetLibrosOrdenados(List<Libro> libros)
    {
        return libros.OrderByDescending(libro => libro.Titulo).ToList();
    }
}
