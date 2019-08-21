using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoSENOVA
{
    public class Proyecto
    {
        #region Atributos
        public List<Proyecto> proyectos = new List<Proyecto>();
        #endregion


        #region Propieades
        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }
        #endregion
        #region Contructores
        public Proyecto(string nombre, double codigo, string area, int duracion)
        {
            Nombre = nombre;
            Nombres = nombre;
            Nombre22 = nombre;
            Codigo = codigo;
            Area = area;
            Duracion = duracion;

        }
        public Proyecto(string area, int duracion)
        {
            Area = area;
            Duracion = duracion;
        }
        public Proyecto()
        {

        }
        #endregion
        #region Metodos
        public void ObtetenerMayores()
        {
            List<Proyecto> pro20 = new List<Proyecto>();

            foreach (var item in proyectos)
            {
                if (item.Codigo > 20 && item.Codigo %2 ==0)
                {
                    pro20.Add(item);
                }
            }
            ImprimirProyecto(pro20);
        }

        public void IngresarProyecto()
        {
            var res = "y";
            while (res == "y")
            {
                Proyecto miproyecto = new Proyecto();
                Console.WriteLine("Ingrese el Nombre del Proyecto");
                miproyecto.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el Codigo");
                miproyecto.Codigo = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Area");
                miproyecto.Area = Console.ReadLine();
                Console.WriteLine("Ingrese la Duracion");
                miproyecto.Duracion = int.Parse(Console.ReadLine());
                proyectos.Add(miproyecto);
                Console.WriteLine("Desea agregar otro proyecto");
                res = Console.ReadLine();
            }
        }

        public void ImprimirProyecto(List<Proyecto> proyecto1)
        {
            foreach (var item in proyecto1)
            {
                Console.WriteLine($"El Nombre del proyecto es:{item.Nombre}");
                Console.WriteLine($"El Codigo del proyecto es:{item.Codigo}");
                Console.WriteLine($"El Area del proyecto es de:{item.Area}");
                Console.WriteLine($"La Duracion del proyecto es de:{item.Duracion} \n");
            }
        }
        #endregion

    }
}


// obtener todos los proyectos cuyo codigo sea mayor a 20 y sea par.
//ordenar los proyectos acendentemente por duracion.
//seleccionar el primer proyecto que sea multiplo de 6.
//listar solo las areas de los proyectos.
//seleccionar solo los proyectos con nomkbre y codigo
//sumar la duracion de todos los proyectos.
//agrupar los proyectos por areas
