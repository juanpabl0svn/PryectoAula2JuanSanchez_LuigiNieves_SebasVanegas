using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioWeb_EPS.Models
{
    public class DBmiembros
    {
        //Lista donde se guardan los integrantes del proyecto actual
        public static List<Miembros> MiembrosDelProyectoActual = new List<Miembros>();

        //Constructor vacio para facilitar la instancia
        public DBmiembros()
        {

        }


        public Miembros Agregar_miembro(string id, string nombre, string apellido, string correo, string rol)
        {
            Miembros miembrosNuevo = new Miembros(id, nombre, apellido, correo, rol);
            MiembrosDelProyectoActual.Add(miembrosNuevo);

            return miembrosNuevo;
        }
    }

    
}