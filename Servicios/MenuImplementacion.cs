using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs123jpribioExamenC.Servicios
{
    /// <summary>
    /// implementacion que implementa el menu
    /// jpr-30/04/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int Consultas()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Opcion 0. Psicologia");
            Console.WriteLine("Opcion 1. Traumatologa");
            Console.WriteLine("Opcion 2. Fisioterapia");
            Console.WriteLine("---------------");
            Console.WriteLine("Escriba la opcion que quiera seleccionar");
            int opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }

        public int menuInicial()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Opcion 0. Cerrar Menu");
            Console.WriteLine("Opcion 1. Registro de llegada");
            Console.WriteLine("Opcion 2. Listado consultas");
            Console.WriteLine("---------------");
            Console.WriteLine("Escriba la opcion que quiera seleccionar");
            int opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }

        public int menuListadoConsultas()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Opcion 0. Volver");
            Console.WriteLine("Opcion 1. Mostrar Consultas");
            Console.WriteLine("Opcion 2. Imprimir Consultas");
            Console.WriteLine("---------------");
            Console.WriteLine("Escriba la opcion que quiera seleccionar");
            int opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }
    }
}
