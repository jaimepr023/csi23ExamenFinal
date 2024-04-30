using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs123jpribioExamenC.Controladores;
using cs123jpribioExamenC.Dtos;

namespace cs123jpribioExamenC.Servicios
{
    /// <summary>
    /// Clase donde se encuentra especificado los metodos de Registros
    /// jpr-30/04/2024
    /// </summary>
    internal class RegistroImplementacion : RegistroInterfaz
    {
        public void registroLlegada()
        {
            string dni = verificarDNI();
            DateTime fechaHoy = DateTime.Today;
            foreach (CitasDto cit in program.citasLista)
            {
              if (cit.DniUsuario.Equals(dni) & (cit.FechaCita.Day == fechaHoy.Day & cit.FechaCita.Month == fechaHoy.Month & cit.FechaCita.Year == fechaHoy.Year))
              {
                    Console.WriteLine($"Espere su turno para la consulta de {cit.Especialidad} en la sala de espera. Su especialista le avisará.");
                    continue;
              }
                if (!(cit.DniUsuario.Equals(dni)) && (cit.FechaCita.Day == fechaHoy.Day & cit.FechaCita.Month == fechaHoy.Month & cit.FechaCita.Year == fechaHoy.Year))
                {
                    Console.WriteLine("No dispone de ninguna cita previa para hoy");
                }
            }
           
        }

        /// <summary>
        /// Metodo privado que verifica el DNI
        /// jpr-30/04/2024
        /// </summary>
        /// <returns>Devuelve un string con el DNI completo</returns>
        private string verificarDNI()
        {
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            char letra;

                Console.WriteLine("Dame la letra de tu DNI (Ponlo en mayusculas)");
                letra = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Dame el numero de su DNI");
                int numeroDNI = Int32.Parse(Console.ReadLine());

            int resto = numeroDNI % 23;
            string DNI;
            if (letras[resto] == letra)
            {
                DNI = $"{numeroDNI}{letra}";
            }
            else
            {
                DNI = "";
            }
            return DNI;

        }


    }
}
