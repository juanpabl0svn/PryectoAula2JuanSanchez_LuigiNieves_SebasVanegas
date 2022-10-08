using FormularioWeb_EPS.Models;
using System;

namespace FormularioWeb_EPS
{
    public partial class Estadisticas_proyecto : System.Web.UI.Page
    {
        //Instancia de proyecto estatico para agregar proyecto buscado
        public static Proyecto cambiarProy = new Proyecto();

        //Instancia de miembros estatico para agregar miembro buscado o para agregar nuevo miembro
        public static Miembros cambiarMiem = new Miembros();

        //Instancia para guardar el proyecto
        BuscarProyecto BuscarProyecto = new BuscarProyecto();

        //Instancia para guardar el miembro
        BuscarMiembro BuscarMiembro = new BuscarMiembro();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Muestra botones y etiquetas que permiten escoger las opciones de eliminar o agregar
        public void MostrarAcciones()
        {
            lblModificar.Visible = true;
            rbOpciones.Visible = true;
            btnIr.Visible = true;
        }
        //Esconde botones y etiquetas que permiten escoger las opciones de eliminar o agregar
        public void EsconderAcciones()
        {
            lblModificar.Visible = false;
            rbOpciones.Visible = false;
            btnIr.Visible = false;
        }

        //Esconde botones y etiquetas que permiten eliminar un miembro
        public void EsconderModificar()
        {
            txtNuevo.Visible = false;
            btnEliminar.Visible = false;
            lblAccion.Visible = false;
            btnCancelar.Visible = false;

        }

        //Esconde el resultado de la operacion exitosa
        public void EsconderResultado()
        {
            lblFuncioa.Visible = false;
        }

        //Muestra las etiquetas, cuadros de texto y botones que permiten agregar miembros
        public void MostrarAgregarMiembro()
        {
            lblregistrarUser.Visible = true;
            lblNombre_user.Visible = true;
            lblApellido_user.Visible = true;
            lblId.Visible = true;
            lblCorreoUser.Visible = true;
            txtId.Visible = true;
            txtNombre_user.Visible = true;
            txtApellido_user.Visible = true;
            txtCorreo_user.Visible = true;
            Rol_user.Visible = true;
            btnGuardar_miembro.Visible = true;
            lbllRol.Visible = true;

        }

        //Esconde las etiquetas, cuadros de texto y botones que permiten agregar miembros
        public void EsconderAgregarMiembro()
        {
            lblregistrarUser.Visible = false;
            lblNombre_user.Visible = false;
            lblApellido_user.Visible = false;
            lblId.Visible = false;
            lblCorreoUser.Visible = false;
            txtId.Visible = false;
            txtNombre_user.Visible = false;
            txtApellido_user.Visible = false;
            txtCorreo_user.Visible = false;
            Rol_user.Visible = false;
            btnGuardar_miembro.Visible = false;
            lbllRol.Visible = false;

        }

        //Muestra el resultado de la operacion, si fue exitosa al eliminar
        public void MostrarResultado()
        {
            lblFuncioa.Visible = true;
            lblFuncioa.Text = $"Miembro eliminado con exito";
        }

        //Muestra botones y etiquetas que permiten eliminar un miembro
        public void MostrarModificar()
        {
            txtNuevo.Visible = true;
            btnEliminar.Visible = true;
            lblAccion.Visible = true;
            btnCancelar.Visible = true;

        }

        //Busca el id del proyecto buscado
        public void btnBuscarProy_Click(object sender, EventArgs e)
        {
            //Hay error si no hay proyectos registrados
            try
            {
                //Si esta vacio o lleno de espacios, dice que agregue id del proyecto
                if (String.IsNullOrEmpty(txtProyectoAEncontrar.Text) || String.IsNullOrWhiteSpace(txtProyectoAEncontrar.Text))
                {
                    lbError_EncontrarProyecto.Visible = true;

                    lbError_EncontrarProyecto.Text = "Ingrese id de un proyecto";


                }
                else
                {

                    lbError_EncontrarProyecto.Visible = false;

                    //Busca en los proyectos el id del proyecto buscado
                    var proyecto = BuscarProyecto.ProyectoRegistrado(int.Parse(txtProyectoAEncontrar.Text));

                    //Si el proyecto fue encontrado, muestra los botones y etiquetas que permiten escoger las opciones de los miembros
                    if (proyecto != null)
                    {

                        MostrarAcciones();
                        EsconderModificar();
                        cambiarProy = proyecto;


                    }
                    else

                    //Muestra proyecto registrado
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
                btnIr.Visible = false;
                
                

            }


        }

        //Elimina el miembro del proyectp
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            lbError_EncontrarProyecto.Visible = false;

            //Busca el id del miembro en el proyecto
            var miembro = BuscarMiembro.MiembroRegistrado(cambiarProy, txtNuevo.Text);

            //Si fue encontrado, se elimina y se esconden los botones y etiquetas que permiten eliminar miembros
            if (miembro != null)
            {
                cambiarProy.Miembros_proyecto.Remove(miembro);
                EsconderModificar();
                MostrarAcciones();
                MostrarResultado();

            }
            else
            //El miembro no fue encontrado
            {
                lbError_EncontrarProyecto.Visible = true;
                lbError_EncontrarProyecto.Text = $"Miembro no encontrado";

            }

            

        }

        //Cancela la operacion que iba a hacer el usuario
        public void btnCancelar_Click(object sender, EventArgs e)
        {
            EsconderModificar();
            MostrarAcciones();

        }

        //Manda al usuario a los botones y etiquetas que permiten agregar o eliminar un miembro
        public void btnIr_Click(object sender, EventArgs e)
        {
            lblGuardado.Visible = false;

            //Hay error cuando no escoge una opcion
            try
            {
                
                //Muestra botones y etiquetas para eliminar
                if (rbOpciones.SelectedItem.Text == "Eliminar")
                {
                    lbError_EncontrarProyecto.Visible = false;
                    EsconderAcciones();
                    EsconderResultado();
                    MostrarModificar();

                }
                //Muestra botones y etiquetas para agregar
                else
                {
                    EsconderAcciones();
                    EsconderResultado();
                    MostrarAgregarMiembro();

                }

            }
            catch (NullReferenceException)
            {
                
                lbError_EncontrarProyecto.Visible = true;
                lbError_EncontrarProyecto.Text = "Seleccione una opción para modificar";

                

            }
          


        }

        //Manda al usuario al menu principal
        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");

        }

        //Borra los cuadros de texto del miembro
        public void BorrarInfo_usuario()
        {
            txtId.Text = "";
            txtNombre_user.Text = "";
            txtApellido_user.Text = "";
            txtCorreo_user.Text = "";
            Rol_user.SelectedIndex = 0;
        }

        //Retorna un valor booleano si algun miembro con el mismo id ya esta en el equipo
        public bool Ya_esta()
        {
            //Busca en los miembros del equipo 
            foreach(Miembros miem in cambiarProy.Miembros_proyecto)
            {
                //Si hay un miembro con el mismo id del nuevo miembro, retorna verdad
                if (txtId.Text == miem.Id)
                {
                    return true;
                }

            }

            return false;

        }

        //Guarda el miembro en los miembros del proyecto
        public void btnGuardar_miembro_Click(object sender, EventArgs e)
        {

            //Pregunta si hay cuadros de texto en blanco o con espacios, si es asi, no se puede agregar al miembro

            if (String.IsNullOrEmpty(txtId.Text) || String.IsNullOrWhiteSpace(txtId.Text))
            {
                lbError_user.Text = "Ingrese documento de identidad";

            }
            else if (Ya_esta())
            {
                lbError_user.Text = "Ya existe un miembro con esa identificacion";

            }
            else if (String.IsNullOrEmpty(txtNombre_user.Text) || String.IsNullOrWhiteSpace(txtNombre_user.Text))
            {
                lbError_user.Text = "Ingrese nombre del miembro";

            }
            else if (String.IsNullOrEmpty(txtApellido_user.Text) || String.IsNullOrWhiteSpace(txtApellido_user.Text))
            {
                lbError_user.Text = "Ingrese apellido del miembro";

            }
            else if (String.IsNullOrEmpty(txtCorreo_user.Text) || String.IsNullOrWhiteSpace(txtCorreo_user.Text))
            {
                lbError_user.Text = "Ingrese correo electronico del usuario";

            }
            //Si el correo del miembro no es de gmail, no se puede registrar al usuario
            else if (!txtCorreo_user.Text.Contains("@gmail.com"))
            {
                lbError_user.Text = "El correo electronico debe ser de gmail";
            }
            //Si no se ha seleccionado un rol para el miembro, no se puede registrar
            else if (Rol_user.SelectedItem.Text == "Seleccionar")
            {
                lbError_user.Text = "Seleccione el rol del usuario";

            }
            else
            {
                //Asigna atributos del nuevo miembro
                cambiarMiem.Id = txtId.Text;
                cambiarMiem.Nombre = txtNombre_user.Text;
                cambiarMiem.Apellido = txtApellido_user.Text;
                cambiarMiem.Correo = txtCorreo_user.Text;
                cambiarMiem.Rol = Rol_user.SelectedItem.Text;

                //Esconde la etiqueta de error
                lbError_user.Visible = false;

                //Agrega al nuevo miembro
                cambiarProy.Miembros_proyecto.Add(cambiarMiem);

                //Muestra una etiqueta para avisar de que el miembro ha sido creado
                lblGuardado.Visible = true;
                lblGuardado.Text = "Miembro agregado con exito";

                //Borra los cuadros de texto del miembro
                BorrarInfo_usuario();

                //Esconde los botones y etiquetas que permiten agregar miembro
                EsconderAgregarMiembro();

                //Aparecen los botones y etiquetas que permiten saber que desea hacer el usuario
                MostrarAcciones();

            }
        }
    }

}
