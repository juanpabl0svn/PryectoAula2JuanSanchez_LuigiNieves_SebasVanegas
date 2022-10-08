using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace FormularioWeb_EPS.Models
{
    public class Proyecto
    {
        //Valor estatico para asignar id
        static int asignar_id = 1;

        //Atributos
        public int id;
        public string impacto;
        public double ingresos;
        public List<Miembros> miembros_proyecto;
        public List<string> departamentos;
        public List<string> herramientas;
        public string nombre;
        public double inversion;


        //Encapsulamiento de atributos
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Impacto { get => impacto; set => impacto = value; }
        public double Inversion { get => inversion; set => inversion = value; }
        public double Ingresos { get => ingresos; set => ingresos = value; }
        public List<Miembros> Miembros_proyecto { get => miembros_proyecto; set => miembros_proyecto = value; }
        public List<string> Departamentos { get => departamentos; set => departamentos = value; }
        public List<string> Herramientas { get => herramientas; set => herramientas = value; }



        //Constructor vacio para facilitar instancias
        public Proyecto()
        {
        }


        //Constructor sobrecargado para crear los objetos
        public Proyecto(string nombre, double inversion, double ingresos, List<string> departamento,
            string impacto_social, List<Miembros> miembros_proyecto, List<string> herramientas_a_usar)
        {
            this.Id = asignar_id ;
            this.Impacto = impacto_social;
            this.Inversion = inversion;
            this.Departamentos = departamento;
            this.Ingresos = ingresos;
            this.Nombre = nombre;
            this.Miembros_proyecto = miembros_proyecto;
            this.Herramientas = herramientas_a_usar;
            asignar_id++;
        }

        

        

       
        
    }
}