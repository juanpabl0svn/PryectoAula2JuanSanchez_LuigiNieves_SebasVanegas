using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioWeb_EPS.Models
{
    public class DB
    {

        //Lista de proyectos registrados
        public static  List<Proyecto> proyectos_registrados = new List<Proyecto>();

        //Encapsulamiento de la lista de proyectos
        public static  List<Proyecto> Proyectos_registrados { get => proyectos_registrados; set => proyectos_registrados = value; } 

        //Generar ejemplos
        public static void Main()
        {

            //Crear lista de herramientas
            List<string> eje1Herramientas = new List<string>() { "IA", "Cloud computing" };
            List<string> eje2Herramientas = new List<string>() { "IA" };
            List<string> eje3Herramientas = new List<string>() { "Biometria", "Firma digital", "IA" };
            List<string> eje4Herramientas = new List<string>() { "Firma digital", "IA" };

            //Crear lista de miembros
            List<Miembros> ejemiembros = new List<Miembros>() { new Miembros("100","JUAN", "SANCHEZ" , "juan@gmail.com", "Ingeniero") ,
                new Miembros("200","LUIGI","NIEVES","luigi@gmail.com","Gerente") , new Miembros("300","SEBASTIAN","VANEGAS","sebas@gmail.com","Jefe de aseo") };

            List<Miembros> eje2miembros = new List<Miembros>() { new Miembros("400","SIMON", "ESTRADA" , "simon@gmail.com", "Ingeniero") ,
                new Miembros("500","JUAN","AGUIRRE","juanagui@gmail.com","Señor el aseo") , new Miembros("600","ALEJANDRO","MARIN","alejo@gmail.com","Financiero") };

            List<Miembros> eje3miembros = new List<Miembros>() { new Miembros("700","DAVID", "HENAO" , "david@gmail.com", "Recepcionista") ,
                new Miembros("800","MIGUEL","HERAZO","migue@gmail.com","Transporte") , new Miembros("900","ESTEBAN","PEREZ","esteban@gmail.com","Ingeniero") };

            List<Miembros> eje4miembros = new List<Miembros>() { new Miembros("1000", "EDISSON", "GUTIERREZ", "edison@gmail.com", "Profesor") };


            List<string> ejeDepa = new List<string>() { "Huila", "Cundinamarca", "Caquetá", "Antioquia" };

            List<string> eje2Depa = new List<string>() { "Huila" };

            List<string> eje3Depa = new List<string>() { "Huila", "Cundinamarca", "Antioquia" };

            List<string> eje4Depa = new List<string>() { "Huila", "Cundinamarca", "Antioquia", "Quindio", "Cauca" };

            //Crear objetos
            Proyecto ejemplo1 = new Proyecto("MONITOR INTELIGENTE", 250000000, 1000000000, ejeDepa, "Queremos hacer algo que haga entender a las personas " +
                "lo importante que son los computadores en la actualidad.", ejemiembros, eje1Herramientas);

            Proyecto ejemplo2 = new Proyecto("AMI", 120000000, 5000000, eje2Depa, "la inteligencia artificial será la llave al proximo paso para el hombre.",
                eje2miembros, eje2Herramientas);

            Proyecto ejemplo3 = new Proyecto("SAFEDOOR", 700000000, 950000000, eje3Depa, "la inseguridad siempre es un gran peligro en la sociedad," +
                " por eso debemos cuidarnos en el mejor lugar del mundo, nuestro hogar.", eje3miembros, eje3Herramientas);


            Proyecto ejemplo4 = new Proyecto("LPLC", 700000000, 950000000, eje4Depa, "Dar a conocer que programar" +
                " no es tandificil como creemos", eje4miembros, eje4Herramientas);

            //Proyecto4RI ejemplo4 = new Proyecto4RI("LPCL",2000000,100000,eje4Depa,"Cambiara la forma de ver la programacion como algo complicado",
            //eje4miembros,eje4Herramientas);



            //Agregar objetos a la lista
            DB.proyectos_registrados.Add(ejemplo1);
            DB.proyectos_registrados.Add(ejemplo2);
            DB.proyectos_registrados.Add(ejemplo3);
            DB.proyectos_registrados.Add(ejemplo4);



        }


    }
}