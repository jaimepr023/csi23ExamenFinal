using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs123jpribioExamenC.Servicios
{
    /// <summary>
    /// Interfaz donde se encuentra la cabecera de los metodos menu
    /// jpr-30/04/2024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// metodo querm uestra por pantalla el menu inicial y te deja elegir una opcion
        /// jpr-30/04/2024
        /// </summary>
        /// <returns>devuelve la opcion</returns>
        public int menuInicial();

        /// <summary>
        /// Submenu que muestra las opciones de consultas
        /// jpr-30/04/2024
        /// </summary>
        /// <returns>devuelve las opciones</returns>
        public int menuListadoConsultas();

        /// <summary>
        /// Submenu que muestra las opciones de consultas especificadas
        /// jpr-30/04/2024
        /// </summary>
        /// <returns></returns>
        public int Consultas();

    }
}
