using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs123jpribioExamenC.Servicios
{
    /// <summary>
    /// Interfaz donde se encuentra los metodos (cabeceras) de las consultas
    /// jpr-30/04/2024
    /// </summary>
    internal interface ConsultasInterfaz
    {

        /// <summary>
        /// Metodo que muestra por pantalla la consulta del dia y la especializacion deseada segun si hay o no
        /// jpr-30/04/2024
        /// </summary>
        public void mostrarConsultasDelDia();


        /// <summary>
        /// Metodo que escribe en el fichero las consultas del dia especificado
        /// </summary>
        public void imprimirConsultasDelDiaAsistida();
    }
}
