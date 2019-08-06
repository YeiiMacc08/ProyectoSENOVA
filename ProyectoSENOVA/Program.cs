using System;

namespace ProyectoSENOVA
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int puntaje = 0;
            Proyecto miProyecto = new Proyecto();
            Proyecto miProyecto2 = new Proyecto();
            Proyecto miProyecto3 = new Proyecto();
            Proyecto miProyecto4 = new Proyecto("Realidad aumentada", 12540, "Sistemas", 10);
            Proyecto miProyecto5 = new Proyecto("TalentoHumano", 5);

            //miProyecto3.IngresarProyecto();
            //miProyecto3.ImprimirProyecto();
            // miProyecto4.ImprimirProyecto();
           miProyecto5.ImprimirProyecto();


            /* miProyecto.Area = "Sistemas";
            miProyecto.Codigo = 12000;
            miProyecto.Duracion = 13;
            miProyecto.Nombre = "Desarrollo internet de las cosas IOT";

            miProyecto2.Area = "Sistemas";
            miProyecto2.Codigo = 3000;
            miProyecto2.Duracion = 21;
            miProyecto2.Nombre = "Desarrollo Arduino";

            Console.WriteLine($" Area: {miProyecto.Area}");
            Console.WriteLine($" Codigo: {miProyecto.Codigo}");
            Console.WriteLine($" Duracion: {miProyecto.Duracion}");
            Console.WriteLine($" Nombre: {miProyecto.Nombre}");

            Console.WriteLine($" Area: {miProyecto2.Area}");
            Console.WriteLine($" Codigo: {miProyecto2.Codigo}");
            Console.WriteLine($" Duracion: {miProyecto2.Duracion}");
            Console.WriteLine($" Nombre: {miProyecto2.Nombre}"); */ 
            


        }
    }
}
