using cs123jpribioExamenC.Dtos;
using cs123jpribioExamenC.Servicios;

namespace cs123jpribioExamenC.Controladores
{
    /// <summary>
    /// Metodo principal donde se encuentra principalmente el main y metodos estaticos
    /// </summary>
    class program
    {
        public static string  ficheroLog = $"C:\\Users\\profesor\\Desktop\\log.txt";
        public static List<CitasDto> citasLista = new List<CitasDto>();

        /// <summary>
        /// metodo main donde se ejecuta el codigo
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            DateTime fechaHoy = DateTime.Today;
            string fichero = $"C:\\Users\\profesor\\Desktop\\citas.txt";
     
            int opcionMenuPrincipal;
            bool cerrarMenu = false;
            int opcionMenuSecundaripo;
            int opcionMenuConsultas;
            string[] datosPorLinea = File.ReadAllLines(fichero);

            MenuInterfaz mi = new MenuImplementacion();
            RegistroInterfaz ri = new RegistroImplementacion();
            ConsultasInterfaz co = new ConsultasImplementacion();
            try
            {
                StreamWriter swL = new StreamWriter(ficheroLog,true);
                foreach (string str in datosPorLinea)
                {
                    string[] contenido = str.Split(';');
                    CitasDto citas = new CitasDto();
                    citas.Id = Convert.ToInt32(contenido[0]);
                    citas.DniUsuario = contenido[1];
                    citas.Nombre = contenido[2];
                    citas.Apellidos = contenido[3];
                    citas.Especialidad = contenido[4];
                    citas.FechaCita = Convert.ToDateTime(contenido[5]);
                    citas.AsisteciaACita= contenido[6];
                    citasLista.Add(citas);

                }     
                while(!cerrarMenu)
                {
                    switch (opcionMenuPrincipal = mi.menuInicial())
                    {
                        case 0:
                            swL.WriteLine("Se ha cerrado el menu");
                            Console.WriteLine("[INFOS]- A continuacion se cerrara el menu");
                            cerrarMenu = true;
                            break;
                        case 1:
                            swL.WriteLine("Opcion 1 eleguida, Registro de llegada");
                            ri.registroLlegada();
                            break; 
                        case 2:
                            swL.WriteLine("Opcion 2 elegida, Listado de consultas");
                            switch (opcionMenuSecundaripo = mi.menuListadoConsultas())
                            {
                                case 0:
                                    swL.WriteLine("Volver, opcion 0");
                                    Console.WriteLine("Se volvera hacia el menu anterior");
                                    break;
                                case 1:
                                    swL.WriteLine("opcion 1, Mostrar consultas");
                                    switch (opcionMenuConsultas = mi.Consultas())
                                    {
                                        case 0:
                                            swL.WriteLine(" Opcion 0,validad fecha y especialidad");
                                            co.mostrarConsultasDelDia();
                                            break;
                                        case 1:
                                            swL.WriteLine(" Opcion 1,validad fecha y especialidad");
                                            co.mostrarConsultasDelDia();
                                            break;
                                        case 2:
                                            swL.WriteLine("Opcion 2, validad fecha y especialidad");
                                            co.mostrarConsultasDelDia();
                                            break;
                                        default:
                                            Console.WriteLine("Al no haber elegido una opcion concreta se le debolvera al menu anterior");
                                            break;
                                    }
                                    break; 
                                case 2:
                                    swL.WriteLine("Opcion 2, Imprimir consultas");
                                    switch (opcionMenuConsultas = mi.Consultas())
                                    {
                                        case 0:
                                            swL.WriteLine("Opcion 0, validad fecha y especialidad e imprimirla en el fichero");
                                            co.imprimirConsultasDelDiaAsistida();
                                            break;
                                        case 1:
                                            swL.WriteLine("Opcion 1, validad fecha y especialidad e imprimirla en el fichero");
                                            co.imprimirConsultasDelDiaAsistida();
                                            break;
                                        case 2:
                                            swL.WriteLine("Opcion 2, validad fecha y especialidad e imprimirla en el fichero");
                                            co.imprimirConsultasDelDiaAsistida();
                                            break;
                                        default:
                                            Console.WriteLine("Al no haber elegido una opcion concreta se le debolvera al menu anterior");
                                            break;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Al no haber elegido una opcion concreta se le debolvera al menu anterior");
                                    break;
                            }
                              break;
                        default:
                            Console.WriteLine("[INFPS] - No ha elegido ninguna de las opciones anteriores por favor vuelve a intentarlo de nueva");
                            break;
                    }
                    swL.Close();
                }
            }catch (Exception ex)
            {
                Console.WriteLine("HA habido un error en el sistema, vuelve a intentarlo mas tarde");
            }

        }
    }
}
