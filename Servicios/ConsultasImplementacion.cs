using cs123jpribioExamenC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using cs123jpribioExamenC.Controladores;

namespace cs123jpribioExamenC.Servicios
{
    /// <summary>
    /// Implementacion que implemnta la interfaz de las consultas
    /// </summary>
    internal class ConsultasImplementacion : ConsultasInterfaz
    {
        public void imprimirConsultasDelDiaAsistida()
        {
            DateTime fechaHoy = DateTime.Today;
            DateTime pedida;
            string[] arrayValidez;
            string ficheroConsultas = $"C:\\Users\\profesor\\Desktop\\citasConAsistencia-{fechaHoy.ToString("ddMMyyyy")}.txt";
            do
            {
                Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
                pedida = Convert.ToDateTime(Console.ReadLine());
                arrayValidez = pedida.ToString().Split('-');
            } while (arrayValidez.Length <= 0);
            try
            {

                StreamWriter sw = new StreamWriter(ficheroConsultas,true);
                foreach (CitasDto cit in program.citasLista)
                {
                    if (cit.FechaCita.Day == pedida.Day & cit.FechaCita.Month == pedida.Month & cit.FechaCita.Year == pedida.Year & cit.AsisteciaACita.Equals("true"))
                    {
                        if (cit.Especialidad.Equals("Psicologia"))
                        {
                            sw.Write($"Nombre completo: {cit.Nombre} {cit.Apellidos}, Hora:{cit.FechaCita.Hour}:{cit.FechaCita.Minute}");
                        }
                        else if (cit.Especialidad.Equals("Traumatologia"))
                        {
                            sw.Write($"Nombre completo: {cit.Nombre} {cit.Apellidos}, Hora: {cit.FechaCita.Hour}:{cit.FechaCita.Minute}");
                        }
                        else if (cit.Especialidad.Equals("Fisioterapia"))
                        {
                            sw.Write($"Nombre completo: {cit.Nombre} {cit.Apellidos}, Hora: {cit.FechaCita.Hour}:{cit.FechaCita.Minute}");
                        }
                        else
                        {
                            sw.Write("No hay datos disponibles para la especialidad y fecha disponibles");
                        }
                    }
                }
                sw.Close();
            }
            catch(IOException ex)
            {
                Console.WriteLine("Ha habido un error con la documentacion al guardar los datos de las consultas, por favor vuelve a intentarlo mas tarde");
            }
           
        }

        public void mostrarConsultasDelDia()
        {
            DateTime pedida;
            string[] arrayValidez;
            do
            {
                Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
                pedida = Convert.ToDateTime(Console.ReadLine());
                arrayValidez = pedida.ToString().Split('-');
            } while (arrayValidez.Length<=0);

            foreach(CitasDto cit in program.citasLista)
            {
                if (cit.FechaCita.Day == pedida.Day & cit.FechaCita.Month == pedida.Month & cit.FechaCita.Year == pedida.Year)
                {
                    if (cit.Especialidad.Equals("Psicologia"))
                    {
                        Console.WriteLine($"Nombre completo: {cit.Nombre} {cit.Apellidos}, Hora: {cit.FechaCita.Hour}:{cit.FechaCita.Minute}");
                    }
                    else if (cit.Especialidad.Equals("Traumatologia"))
                    {
                        Console.WriteLine($"Nombre completo: {cit.Nombre} {cit.Apellidos}, Hora: {cit.FechaCita.Hour}:{cit.FechaCita.Minute}");
                    }
                    else if (cit.Especialidad.Equals("Fisioterapia"))
                    {
                        Console.WriteLine($"Nombre completo: {cit.Nombre} {cit.Apellidos}, Hora: {cit.FechaCita.Hour}:{cit.FechaCita.Minute}");
                    }
                    else
                    {
                        Console.WriteLine("No hay datos disponibles para la especialidad y fecha disponibles");
                    }
                }
            }
        }
    }
}
