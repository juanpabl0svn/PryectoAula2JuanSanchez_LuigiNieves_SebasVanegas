using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioWeb_EPS.Models
{
    
    public class Miembros
    {
        //Atributos
        string id,nombre, apellido, correo, rol;

        //Constructor vacio para facilitar las instancias
        public Miembros()
        {
        }

        //Constructor para crear objetos
        public Miembros(string id, string nombre, string apellido, string correo, string rol)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.Rol = rol;
        }

        //Encapsulamiento de atributos
        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Rol { get => rol; set => rol = value; }
    }
}