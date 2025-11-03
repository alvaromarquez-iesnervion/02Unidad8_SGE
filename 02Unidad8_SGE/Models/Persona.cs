using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Unidad8_SGE.Models;

public class Persona
{   
    // Propiedades públicas
    public int Id { get; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellidos { get; set; } = string.Empty;

    // Constructor vacío requerido
    public Persona()
    {
       
    }

    // Constructor completo
    public Persona(int id, string nombre, string apellidos)
    {
        Id = id;
        Nombre = nombre;
        Apellidos = apellidos;
    }
}
