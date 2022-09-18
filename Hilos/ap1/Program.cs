using System;
using System.Threading;
namespace ap2
{
    class Program
    {
        //HILOS Y PROCESO
        //Proceso:
        static void Main(string[] args)
        {
        
            //Hilo 2:
            Thread t = new Thread(MetodoSaludo);
            t.Start();
            //Hilo 2:
            Thread t2 = new Thread(MetodoSaludo);
            t2.Start();
            
            Console.WriteLine("Hola alumnos desde thread o hilo 1");
            Thread.Sleep(4000);
            Console.WriteLine("Hola alumnos desde thread o hilo 1");
            Thread.Sleep(4000);
            Console.WriteLine("Hola alumnos desde thread o hilo 1");
            Thread.Sleep(4000);
            Console.WriteLine("Hola alumnos desde thread o hilo 1");

            // MetodoSaludo();

        }
        //Hilo 2
        static void MetodoSaludo()
        {
            Console.WriteLine("Hola alumnos desde thread o hilo 2");
            Thread.Sleep(4000);
            Console.WriteLine("Hola alumnos desde thread o hilo 2");
            Thread.Sleep(4000);
            Console.WriteLine("Hola alumnos desde thread o hilo 2");
            Thread.Sleep(4000);
            Console.WriteLine("Hola alumnos desde thread o hilo 2");
        }
    }
}