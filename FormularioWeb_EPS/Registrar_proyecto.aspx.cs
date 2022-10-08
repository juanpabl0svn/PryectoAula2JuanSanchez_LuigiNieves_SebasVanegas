using System;
using System.Collections.Generic;
using FormularioWeb_EPS.Models;




namespace FormularioWeb_EPS
{
    public partial class WebForm_IMC : System.Web.UI.Page
    {

        //Instancia para guardar miembros al proyecto
        DBmiembros GuardarMiembro = new DBmiembros();

        //Lista donde se guardan las herramientas del proyecto actual
        public List<string> Herramientas_proyecto = new List<string>();

        //Lista donde se guardan los departamentos del proyecto actual
        public List<string> Departamentos_proyecto = new List<string>();


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }     


        //Guarda el proyecto en los proyectos registraados
        public void btnGuardar_Click(object sender, EventArgs e)
        {
            
            int departamento_seleccionado = CheckBoxDepartamentos.SelectedIndex, herramienta_seleccionada = CheckBoxHerramientas.SelectedIndex;

            //Si los cuadros de textos estan vacios, no se puede registrar el proyecto

            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                lbError.Text = "Ingrese un nombre para el proyecto";
            }
            //Si la invesion no es un numero, no se puede registrar el proyecto
            else if (!double.TryParse(txtInversion.Text, out _) || double.Parse(txtInversion.Text) <= 0) 
            {
                lbError.Text = "Ingrese un valor de inversion valido";
            }
            //Si el ingreso no es un numero, no se puede registrar el proyecto
            else if (!double.TryParse(txtIngresos.Text, out _) || double.Parse(txtIngresos.Text) <= 0)
            {
                lbError.Text = "Ingrese un valor de ingresos a 3 años valido";    
            }
            //Si no hay departamentos seleccionados, no se puede registrar
            else if (departamento_seleccionado == -1)
            {
                lbError.Text = "Seleccione almenos un departamento";
            }
            else if (String.IsNullOrEmpty(txtImpacto_social.Text))
            {
                lbError.Text = "Ingrese un impacto social con palabras";

            }
            //Si no hay herramientas seleccionadas, no se puede registrar
            else if (herramienta_seleccionada == -1)
            {
                lbError.Text = "Seleccione almenos una herrramienta";

            }
            //Si hay miembros en el proyecto, no se puede registrar
            else if (DBmiembros.MiembrosDelProyectoActual.Count == 0)
            {
                lbError.Text = "Debe agregar almenos un miembro al proyecto";

            }
            //Se registra el proyecto
            else
            {
                lbError.Visible = false;

                //Itera en los departamentos disponibles
                for (int i = 0; i < CheckBoxDepartamentos.Items.Count; i++)
                {
                    //Si el departamento esta seleccionado, lo agrega a la lista de departamentos
                    if (CheckBoxDepartamentos.Items[i].Selected)
                    {

                        Departamentos_proyecto.Add(CheckBoxDepartamentos.Items[i].Text);

                    }

                }

                //Itera en las herramientas disponibles
                for (int i = 0; i < CheckBoxHerramientas.Items.Count; i++)
                {
                    //Si la herramienta esta seleccionada, lo agrega a la lista de herramientas
                    if (CheckBoxHerramientas.Items[i].Selected)
                    {

                        Herramientas_proyecto.Add(CheckBoxHerramientas.Items[i].Text);

                    }

                }

                //Crea un nuevo objeto y lo agrega a la lista de proyectos registrados, luego borra la informacion de los cuadros de texto
                DB.Proyectos_registrados.Add(new Proyecto(txtNombre.Text, double.Parse(txtInversion.Text), double.Parse(txtIngresos.Text),Departamentos_proyecto , txtImpacto_social.Text , DBmiembros.MiembrosDelProyectoActual, Herramientas_proyecto));
                BorrarInfo_proyecto();
                DBmiembros.MiembrosDelProyectoActual.Clear();
                
                
            }

        }

        //Borra la informacion en los cuadros de texto del miembro
        public void BorrarInfo_usuario()
        {
            txtId.Text = "";
            txtNombre_user.Text = "";
            txtApellido_user.Text = "";
            txtCorreo_user.Text = "";
            Rol_user.SelectedIndex = 0;
        }

        //Borra la informacion en los cuadros de texto del proyecto
        public void BorrarInfo_proyecto()
        {
            txtNombre.Text = "";
            txtIngresos.Text = "";
            txtInversion.Text = "";
            txtImpacto_social.Text = "";
            CheckBoxDepartamentos.Items.Clear();
            CheckBoxHerramientas.Items.Clear();
        }

        //Guarda el miembro en una lista para luego ser agregada al proyecto
        public void btnGuardar_miembro_Click(object sender, EventArgs e)
        {
            //Si los cuadros de texto estan vacios, no se puede registrar el miembro
            if ((String.IsNullOrEmpty(txtId.Text) || String.IsNullOrWhiteSpace(txtId.Text)) && int.TryParse(txtId.Text, out _))
            {
                lbError_user.Text = "Ingrese documento de identidad";

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
            //Si el correo del usuario no es de gmail, no se puede registrar
            else if (!txtCorreo_user.Text.Contains("@gmail.com"))
            {
                lbError_user.Text = "El correo electronico debe ser de gmail";
            }
            //Si no selecciona un rol, no se puede registrar el proyecto
            else if (Rol_user.SelectedItem.Text == "Seleccionar")
            {
                lbError_user.Text = "Seleccione el rol del usuario";

            }
            //Crea un objeto miembro y lo agrega en una lista de miembros de este proyecto, luego borra la informacion de los cuadros de texto
            else
            {

                lbError_user.Visible = false;
                GuardarMiembro.Agregar_miembro(txtId.Text,txtNombre.Text,txtApellido_user.Text,txtCorreo_user.Text, Rol_user.SelectedItem.Text);
                BorrarInfo_usuario();

            }
        }

        //envia al usuario al menu principal
        protected void btnExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");

        }
    }
}