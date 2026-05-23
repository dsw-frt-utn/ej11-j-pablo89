using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno>? _alumnos;

    public CasoDictionary()
    {
        _alumnos = new Dictionary<int, Alumno>();
    }

    public void AgregarAlumno(Alumno? alumno)
    {
        if (alumno != null)
        {
            _alumnos?.Add(alumno.Id, alumno);
        }
    }

    public Alumno? ObtenerAlumnoPorClave(int clave)
    {
        if (clave >= 0)
        {
            foreach (var item in _alumnos)
            {
                if(clave.Equals(item.Key))
                {
                    return item.Value;
                }
            }
        }
        return null;
    }

    public Dictionary<int, Alumno>? ObtenerAlumnos()
    {
        return _alumnos;
    }

    public void EliminarAlumnoPorClave(int clave)
    {
        if (clave >= 0)
        {
            _alumnos?.Remove(clave);
        }
    }



}
