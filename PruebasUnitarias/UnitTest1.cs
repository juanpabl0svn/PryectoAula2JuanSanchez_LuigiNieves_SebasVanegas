using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormularioWeb_EPS.Models;
using System.Collections.Generic;

namespace PruebasUnitarias
{
    [TestClass]
    public class Pruebas
    {
        [TestMethod]
        //Existe un miembro con ese id en el proyecto
        public void Ya_esta_ShouldReturn()
        {

            BuscarMiembro pruebasMiembro = new BuscarMiembro();

            //Crea los ejemplos
            DB.Main();

            //El primer miembro del primer proyecto tiene id = 100
            var esperado = DB.proyectos_registrados[0].Miembros_proyecto[0];

            //ACT
            //Busca en el primer proyecto miembro con el id = 100
            var result = pruebasMiembro.MiembroRegistrado(DB.proyectos_registrados[0], "100");

            //ASERT
            //Retrona el miembro con el di buscado, y si es el mismo, todo funciona bien
            Assert.AreEqual(esperado, result);
        }

        [TestMethod]
        //Existe un proyecto con el id
        public void BuscarPoryecto_ShouldReturn()
        {
            BuscarProyecto pruebasProyecto = new BuscarProyecto();

            //Se espera que retorne nada ya que se entrega un id que no esta registrada
            List<Proyecto> esperadoProy = null;

            //Busca un proyecto con el id entregado id = 8
            var result = pruebasProyecto.ProyectoRegistrado(8);

            //No existe asi que debe retornar null, si es asi, funciona correctamente
            Assert.AreEqual(esperadoProy, result);

        }

        [TestMethod]
        //Crear objeto miembro y agregarlo a una lista 
        public void AgregarMiembro_ShouldReturn()
        {
            DBmiembros pruebasNuevoMiembro = new DBmiembros();

            
            //Se crea un miembro
            Miembros esperadoMiem = new Miembros("123","Juan","Sanchez","Juan@gmail.com","Financiero");

            //ACT
            //Se envian los atributos del miembro creado
            var result = pruebasNuevoMiembro.Agregar_miembro(esperadoMiem.Id, esperadoMiem.Nombre, esperadoMiem.Apellido, esperadoMiem.Correo, esperadoMiem.Rol);


            //ASERT
            //Si creo el objeto y lo agrego a la lista, todo funciono bien
            Assert.AreEqual(DBmiembros.MiembrosDelProyectoActual[0], result);

            //Limpia la lista ya que es estatica
            DBmiembros.MiembrosDelProyectoActual.Clear();


        }
    }
}
