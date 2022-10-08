using System;
using System.Linq;
using System.Text;
using FormularioWeb_EPS.Models;

namespace FormularioWeb_EPS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        public void Page_Load(object sender, EventArgs e)
        {
        }

        //Muestra la informaciond de todos los proyectos registrados
        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            //Variable que permite escribir en un cuadro de texto
            StringBuilder escribir = new StringBuilder();
         
            //Si hay proyectos registrados, imprime
            if (DB.Proyectos_registrados.Count() > 0)
            {
                lbError.Visible = false;

                //Imprime la informaciond e cada proyecto
                foreach (Proyecto proy in DB.proyectos_registrados)
                {
                    escribir.AppendLine($"ID: {proy.Id}");                
                    escribir.AppendLine($"Nombre: {proy.Nombre}");               
                    escribir.AppendLine($"Inversion: {proy.Inversion}");                 
                    escribir.AppendLine($"Ingresos: {proy.Ingresos}");                  
                    escribir.AppendLine($"Departamentos:\n");

                    //Imprime los departamentos
                    foreach (string departamento in proy.Departamentos)
                    {                  
                        escribir.AppendLine($"-{departamento}");

                    }
                    escribir.AppendLine($"\nImpacto:{proy.Impacto}\n");
                    escribir.AppendLine($"Miembros:\n");

                    //Imprime los miembros del proyecto
                    foreach (Miembros miemb in proy.Miembros_proyecto)
                    {
                        escribir.AppendLine($"ID:{miemb.Id}");
                        escribir.AppendLine($"Nombre:{miemb.Nombre}");
                        escribir.AppendLine($"Apellido:{miemb.Apellido}");
                        escribir.AppendLine($"Correo:{miemb.Correo}");
                        escribir.AppendLine($"Rol:{miemb.Rol}\n");

                    }

                    escribir.AppendLine($"Herraminetas usadas:\n");

                    //Imprime las herramientas del proyecto
                    foreach (string herra in proy.Herramientas)
                    {  



                        escribir.AppendLine($"-{herra}");

                    }

                    escribir.AppendLine($"\n-------------------------------------------------------------------------------------------------------------------------");


                }

                //Escribe la informacion en el cuadro de texto
                txtProyectos.Text = escribir.ToString();
                



            }
            else
            //Muestra vacio
            {
                lbError.Visible = true;
                lbError.Text = "Vacio";

                


            }




        }

        //Manda al usuario al menu principal
        protected void btnExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");

        }
    }
}