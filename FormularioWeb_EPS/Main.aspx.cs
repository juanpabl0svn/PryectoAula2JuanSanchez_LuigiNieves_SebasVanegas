using System;
using FormularioWeb_EPS.Models;



namespace FormularioWeb_EPS
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Envia al usuario al formulario de ver proyectos
        protected void btnVerProy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ver_proyectos.aspx");
        }

        //Envia al usuario al formulario de registrar proyectos
        protected void btnRegistrarProy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrar_proyecto.aspx");

        }

        //Envia al usuario al formulario de modificar proyectos
        public void btnModificar_proyecto_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("Modificar_proyecto.aspx");

        }

        //Crea ejemplos para que el usuario pueda probar el software
        protected void btnEjemplos_Click(object sender, EventArgs e)
        {
            DB.Main();
        }

        //Envia al usuario al formulario eliminar / agregar miembro
        protected void btnAgregar_eliminar_miembro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Miembro_agregar_eliminar.aspx");

        }

        //Envia al usuario al formulario de estadisticas de los proyectos
        protected void btnEstadisticaProy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estadisticas_proyecto.aspx");

        }
    }
}