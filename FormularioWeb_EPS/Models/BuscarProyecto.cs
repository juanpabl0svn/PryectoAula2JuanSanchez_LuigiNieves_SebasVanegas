using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioWeb_EPS.Models
{
    public class BuscarProyecto
    {
        public BuscarProyecto()
        {

        }

        public Proyecto ProyectoRegistrado(int id)
        {
            foreach(Proyecto proy in DB.proyectos_registrados)
            {
                if (id == proy.id)
                {
                    return proy;
                }

            }
            return null;

        }
    }
}