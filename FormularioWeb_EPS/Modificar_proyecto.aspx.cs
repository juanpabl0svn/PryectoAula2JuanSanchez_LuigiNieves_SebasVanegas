using FormularioWeb_EPS.Models;
using System;


namespace FormularioWeb_EPS
{
    public partial class Modificar_proyecto : System.Web.UI.Page
    {
        //Instancia de proyecto estatico para agregar proyecto buscado
        public static Proyecto cambiarProy = new Proyecto();

        //Instancia de BuscarProyecto que permite encontrar un proyecto buscado
        BuscarProyecto BuscarProyecto = new BuscarProyecto();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        //Agrega el nombre del atributo a cambiar en un label
        public void Modificaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAccion.Text = $"{(ddlModificaciones.SelectedItem.Text).ToLower()} a modificar";
        }

        //Busca el atributo que desea modificar el usuario
        public int Atributo_a_modificar()
        {
            if (ddlModificaciones.SelectedIndex.Equals(0))
            {
                return -1;
            }
            else if (ddlModificaciones.SelectedIndex.Equals(1))
            {
                return 1;

            }
            else if (ddlModificaciones.SelectedIndex.Equals(2))
            {
                return 2;


            }
            else if (ddlModificaciones.SelectedIndex.Equals(3))
            {
                return 3;
            }
            else if (ddlModificaciones.SelectedIndex.Equals(3))
            {
                return 4;

            }
            else
            {
                return 5;
            }

        }

        //Muestra que el dato ha sido modificado con exito
        public void MostrarResultado()
        {
            lblFuncioa.Visible = true;
            lblFuncioa.Text = $"{ddlModificaciones.SelectedItem.Text} modificado correctamente";
        }

        //Esconde que el dato ha sido modificado con exito
        public void EsconderResultado()
        {
            lblFuncioa.Visible = false;
        }

        //Esconde los botones y cuadros de texto que permiten modificar
        public void EsconderModificar()
        {
            txtNuevo.Visible = false;
            btnCambiar.Visible = false;
            lblAccion.Visible = false;
            btnCancelar.Visible = false;
            
        }

        //Muestra los botones y cuadros de texto que permiten modificar
        public void MostraModificar()
        {
            txtNuevo.Visible = true;
            btnCambiar.Visible = true;
            lblAccion.Visible = true;
            btnCancelar.Visible = true;
        }

        //Muestra los botones y opciones que permiten que se va a modificar
        public void MostrarAcciones()
        {
            lblModificar.Visible = true;
            ddlModificaciones.Visible = true;
            btnIr.Visible = true;           
        }

        //Esconde los botones y opciones que permiten que se va a modificar
        public void EsconderAcciones()
        {
            lblModificar.Visible = false;
            ddlModificaciones.Visible = false;
            btnIr.Visible = false;
        }

        //Busca en la lista de proyectos el id del proyecto buscado
        public void btnBuscarProy_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (String.IsNullOrEmpty(txtProyectoAEncontrar.Text))
                {
                    lbError_EncontrarProyecto.Visible = true;

                    lbError_EncontrarProyecto.Text = "Ingrese id de un proyecto";

                }
                else
                {




                    lbError_EncontrarProyecto.Visible = false;

                    var proyecto = BuscarProyecto.ProyectoRegistrado(int.Parse(txtProyectoAEncontrar.Text));

                    if (proyecto != null)
                    {

                        MostrarAcciones();
                        EsconderModificar();
                        cambiarProy = proyecto;


                    }
                    else
                    {
                        lbError_EncontrarProyecto.Visible = true;
                        lbError_EncontrarProyecto.Text = "Proyecto no registrado";
                        EsconderAcciones();
                        EsconderModificar();
                    }
                }

            }
            catch (FormatException)
            {
                lbError_EncontrarProyecto.Visible = true;
                lbError_EncontrarProyecto.Text = "Ingrese id de un proyecto";
                lblModificar.Visible = false;
                ddlModificaciones.Visible = false;
                btnIr.Visible = false;

            }
            

        }

        //Permite realizar la modificacion del atributo apareciendo los controladores
        public void btnIr_Click(object sender, EventArgs e)
        {
            if (Atributo_a_modificar() == -1)
            {
                lbError_EncontrarProyecto.Visible = true;
                lbError_EncontrarProyecto.Text = "Seleccione una opción para modificar";

            }
            else
            {
                lbError_EncontrarProyecto.Visible = false;
                EsconderAcciones();
                EsconderResultado();
                MostraModificar();

            }
            

        }

        //Modifica el atributo del proyecto
        public void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                lbError_EncontrarProyecto.Visible = false;
                if (Atributo_a_modificar() == 1)
                {
                    cambiarProy.Nombre = txtNuevo.Text;

                }
                else if (Atributo_a_modificar() == 2)
                {
                    cambiarProy.Inversion = float.Parse(txtNuevo.Text);

                }
                else if (Atributo_a_modificar() == 3)
                {
                    if (float.Parse(txtNuevo.Text) <= cambiarProy.Ingresos)
                    {
                        lbError_EncontrarProyecto.Visible = true;
                        lbError_EncontrarProyecto.Text = $"Ingrese valor de ingresos mayor al que estaba, sino, cancele la operacion ( valor anterior : {cambiarProy.Ingresos}";

                    }
                    else
                    {
                        cambiarProy.Ingresos = float.Parse(txtNuevo.Text);

                    }
                    
                }
                

                if (lbError_EncontrarProyecto.Visible)
                {
                    

                }
                else
                {
                    EsconderModificar();
                    MostrarAcciones();
                    MostrarResultado();
                }

                

            }
            catch (FormatException)
            {
                lbError_EncontrarProyecto.Visible = true;
                lbError_EncontrarProyecto.Text = "Ingrese un valor valido";

            }
 


        }

        //Volver a la pagina de inicio
        public void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");

        }

        //No hace anda y solo muestra de nuevo las opciones de modificar
        public void btnCancelar_Click(object sender, EventArgs e)
        {
            EsconderModificar();
            MostrarAcciones();

        }

    }
}