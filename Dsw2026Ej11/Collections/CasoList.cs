using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno>? _alumnos;

    public CasoList()
    {
        _alumnos = new List<Alumno>();
    }

    public void AgregarAlumno(Alumno? alumno)
    {
        if (alumno != null)
        {
            _alumnos?.Add(alumno);
        }
    }
    public List<Alumno>? ObtenerAlumnos()
    {
        return _alumnos;
    }

    public Alumno? ObtenerAlumnoPorNombre(string nombre)
    {
        if (!string.IsNullOrEmpty(nombre))
        {
            foreach (var item in _alumnos)   
            {
                if (item.Nombre.Equals(nombre))
                {
                    return item;
                }
            }
        }
        return null;
    }

    public void EliminarAlumno(Alumno? alumno)
    {
        if (alumno != null)
        {
            _alumnos?.Remove(alumno);
        }
    }

    public void EliminarAlumnoPorPosicion(int posicion)
    {
        if(posicion >= 0 && posicion < _alumnos?.Count)
        {
            _alumnos?.RemoveAt(posicion);
        }
    }
}