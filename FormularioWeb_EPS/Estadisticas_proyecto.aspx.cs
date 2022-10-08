using FormularioWeb_EPS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace FormularioWeb_EPS
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        //Variabe que me permite ingresar texto al cuadro de texto
        StringBuilder escribir = new StringBuilder();

        //Variable con la que filtro los proyectos
        List<Proyecto> objeto = new List<Proyecto>();

        


        protected void Page_Load(object sender, EventArgs e)
        {

        }


        //Muestra la informacion del proyecto con mas herramientas que tenga mayor ingresos
        protected void btnMasDepartamentos_Click(object sender, EventArgs e)
        {
            //Hay error si no hay proyectos
            try
            {
                //Vuelve invisible la etiqueta de error
                lbError.Visible = false;

                //variable que es el minimo de departamentos
                int min = 0;

                

                //Busca en los proyectos
                foreach (Proyecto revisar in DB.proyectos_registrados)
                {
                    //Pregunta por la que tenga mas departamentos
                    if (revisar.Departamentos.Count() > min)
                    {
                        min = revisar.Departamentos.Count();
                        objeto.Add(revisar);

                    }


                }

                //Asigna a una variable el proyecto con mas ingresos
                var ProyectoConMasIngresos = objeto.Where(x => x.Ingresos == objeto.Max(y => y.Ingresos)).ToList();


                //Guarda la informacion del proyecto
                escribir.AppendLine($"ID: {ProyectoConMasIngresos[0].Id}");
                escribir.AppendLine($"Nombre: {ProyectoConMasIngresos[0].Nombre}");
                escribir.AppendLine($"Inversion: {ProyectoConMasIngresos[0].Inversion}");
                escribir.AppendLine($"Ingresos: {ProyectoConMasIngresos[0].Ingresos}");
                escribir.AppendLine($"Departamentos:\n");

                foreach (string departamento in ProyectoConMasIngresos[0].Departamentos)
                {
                    
                    escribir.AppendLine($"-{departamento}");

                }
                escribir.AppendLine($"\nImpacto:{ProyectoConMasIngresos[0].Impacto}\n");

                foreach (Miembros miemb in ProyectoConMasIngresos[0].Miembros_proyecto)
                {
                    escribir.AppendLine($"ID:{miemb.Id}");
                    escribir.AppendLine($"Nombre:{miemb.Nombre}");
                    escribir.AppendLine($"Apellido:{miemb.Apellido}");
                    escribir.AppendLine($"Correo:{miemb.Correo}");
                    escribir.AppendLine($"Rol:{miemb.Rol}\n");

                }

                escribir.AppendLine($"Herraminetas usadas:\n");

                foreach (string herra in ProyectoConMasIngresos[0].Herramientas)
                {

                    escribir.AppendLine($"-{herra}");

                }

                escribir.AppendLine($"\n-------------------------------------------------------------------------------------------------------------------------");

                //Asigna la informacion del proyecto en el cuadro de texo
                txtProyectos.Text = escribir.ToString();

                //Limpia la lista estatica
                objeto.Clear();

            }
            //Lista fuera de rango
            catch (ArgumentOutOfRangeException)
            {
                //Pone visible la etiqueta de error
                lbError.Visible = true;
                lbError.Text = "Vacio";

            }

            }

        //Salir al menu principal 
        protected void btnExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }

        //Muestra el nombre de los 3 proyectos con mas rentabilidad
        protected void btnRentabilidad_Click(object sender, EventArgs e)
        {
            //Hay errror cuando hay menos de 3 proyectos
            try
            {
                //Si no hay proyectos, saldra vacio
                if (DB.proyectos_registrados.Count == 0)
                {
                    lbError.Visible = true;
                    lbError.Text = "Vacio";
                }
                else
                {

                    lbError.Visible = false;

                    //Ordena los proyectos de menor a mayor en rentabilidad
                    var listaOrdenada = DB.proyectos_registrados.OrderBy(x => (x.Ingresos - x.Inversion)).ToList();


                    //Imprime los 3 ultimos
                    for (int i = (listaOrdenada.Count() - 1); i >= (listaOrdenada.Count() - 3); i--)
                    {
                        //Guarda el nombre de los proyectos
                        escribir.AppendLine($"-{listaOrdenada[i].Nombre}");

                    }

                    //Ingresa los nombres de los proyectos
                    txtProyectos.Text = escribir.ToString();
                    txtProyectos.ReadOnly = true;
                }

            }
            //Indice fuera de rango, no hay suficientes proyectos
            catch (ArgumentOutOfRangeException)
            {
                lbError.Visible = true;
                lbError.Text = "Menos de 3 proyectos registrados";
            }

            

        }

        //Muestra los proyectos con mas de 3 departamentos
        protected void btnMas3Departamentos_Click(object sender, EventArgs e)
        {
            //Si no hay proyectos, esta vacio
            if (DB.proyectos_registrados.Count() == 0)
            {
                lbError.Visible = true;
                lbError.Text = "Vacio";               
            }
            else
            {
                lbError.Visible = false;

                //Revisa los departamentos de cada proyecto
                foreach (var item in DB.proyectos_registrados)
                {
                    //Si el proyecto tiene mas de 3 departamentos, gurda el nombre
                    if (item.departamentos.Count() > 3)
                    {
                        escribir.AppendLine($"-{item.Nombre}");

                    }

                }


            }
            
            //Escribe el nombre de los proyectos guardados
            txtProyectos.Text = escribir.ToString();
            

        }

        //Muestra la suma de los ingresos de los proyectos
        protected void btnsumaIngresos_Click(object sender, EventArgs e)
        {
            //Si no hya proyectos, muestra vacio
            if (DB.proyectos_registrados.Count == 0)
            {
                lbError.Visible = true;
                lbError.Text = "Vacio";


            }
            else
            {
                lbError.Visible = false;
                double suma = 0;

                //Suma los ingresos de cada proyecto registrado
                foreach (Proyecto proy in DB.proyectos_registrados)
                {
                    //Guarda el valor en una variable
                    suma += proy.Ingresos;
                }

                //Guarda el texto con la variale
                escribir.AppendLine($"La suma de todos los ingresos es  ${suma}");


                //Imprime el texto guardado
                txtProyectos.Text = escribir.ToString();
                

            }
            

        }

        //Muestra la suma de las inversiones de los proyectos
        protected void btnSumaInversion_Click(object sender, EventArgs e)
        {
            //SI no hay proyectos, muestra vacio
            if (DB.proyectos_registrados.Count == 0)
            {
                lbError.Visible = true;
                lbError.Text = "Vacio";
                

            }
            else
            {
                lbError.Visible = false;
                double suma = 0;

                //Suma las inversiones de cada proyecto registrado
                foreach (Proyecto proy in DB.proyectos_registrados)
                {
                    //Guarda el valor en una variable
                    suma += proy.Inversion;
                }

                //Guarda el texto con la variale
                escribir.AppendLine($"La suma de todos las inversiones es  ${suma}");


                //Imprime el texto guardado
                txtProyectos.Text = escribir.ToString();

            }

        }

        //Muestra el nombre y los miembros del proyecto con mas herramientas
        protected void btnmasHerramientas_Click(object sender, EventArgs e)
        {
            //Hay error cuando no hay proyectos registrados
            try
            {
                lbError.Visible = false;

                //Guarda el proyecto con ams herramientas
                var masHerramientas = DB.proyectos_registrados.Where(x => x.Herramientas.Count() == (DB.proyectos_registrados.Max(y => y.Herramientas.Count()))).ToList();


                //Guarda la informacion del proyecto
                escribir.AppendLine($"Nombre: {masHerramientas[0].Nombre}");
                escribir.AppendLine($"Miembros:\n");

                foreach (Miembros miemb in masHerramientas[0].Miembros_proyecto)
                {
                    escribir.AppendLine($"ID:{miemb.Id}");
                    escribir.AppendLine($"Nombre:{miemb.Nombre}");
                    escribir.AppendLine($"Apellido:{miemb.Apellido}");
                    escribir.AppendLine($"Correo:{miemb.Correo}");
                    escribir.AppendLine($"Rol:{miemb.Rol}\n");

                }

                //Imprime la informacion guardada
                txtProyectos.Text = escribir.ToString();

            }
            catch (ArgumentOutOfRangeException)
            {
                lbError.Visible = true;
                lbError.Text = "Vacio";

            }




        }

        //Muestra la cantidad de proyectos que tiene inteligencia artificial
        protected void btnproyectosIA_Click(object sender, EventArgs e)
        {
            //Si no hay proyectos registrados, muestra vacio
            if (DB.proyectos_registrados.Count == 0)
            {
                lbError.Visible = true;
                lbError.Text = "Vacio";

            }
            else
            {
                lbError.Visible = false;

                //Cantidad de proyectos con inteligencia artificial
                int cantidadHerra = 0;

                //Busca en todos los proyectos
                foreach(Proyecto proy in DB.proyectos_registrados)
                {
                    //Busca en las herramientas de cada proyecto
                    foreach(string herra in proy.Herramientas)
                    {
                        //Si en las herramientas se encuentra inteligencia artificial, le suma 1 a la variable
                        if(herra == "IA")
                        {
                            cantidadHerra++;

                        }

                    }

                }

                //Guarda la cantidad de proyectos con inteligencia artificial con un texto
                escribir.AppendLine($"Hay {cantidadHerra} proyectos con inteligencia artificial");

                //Imprime el texot guardado
                txtProyectos.Text = escribir.ToString();


            }

        }
    }
}