using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs123jpribioExamenC.Dtos
{
    internal class CitasDto
    {
        int id;
        string dniUsuario = "aaaaa";
        string nombre = "aaaaa";
        string apellidos = "aaaaa";
        string especialidad = "aaaaa";
        DateTime fechaCita = DateTime.Now;
        string asisteciaACita = "aaaaa";

        public string DniUsuario { get => dniUsuario; set => dniUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public string AsisteciaACita { get => asisteciaACita; set => asisteciaACita = value; }
        public int Id { get => id; set => id = value; }

        public CitasDto(int id, string dniUsuario, string nombre, string apellidos, string especialidad, DateTime fechaCita, string asisteciaACita)
        {
            this.id = id;
            this.dniUsuario = dniUsuario;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.especialidad = especialidad;
            this.fechaCita = fechaCita;
            this.asisteciaACita = asisteciaACita;
        }

        public CitasDto()
        {
        }
    }
}
