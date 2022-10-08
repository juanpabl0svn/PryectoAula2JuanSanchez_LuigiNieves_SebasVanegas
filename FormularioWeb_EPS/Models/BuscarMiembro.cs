using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioWeb_EPS.Models
{
    public class BuscarMiembro
    {
        public BuscarMiembro()
        {

        }

        public Miembros MiembroRegistrado(Proyecto proy, string id)
        {
            foreach(Miembros miem in proy.Miembros_proyecto)
            {
                if (id == miem.Id)
                {
                    return miem;
                }
            }

            return null;

        }
    }
}