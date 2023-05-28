using PPAI_RosaMosqueta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Data
{
    public class Data
    {
        // CLIENTES
        // no me toma la clase Cliente pero serían así:
        public static Cliente Cliente1 { get; set; } = new Cliente(43925111, "Franco Ambrosini", 3513901979);
        public static Cliente Cliente2 { get; set; } = new Cliente(43990147, "Alejo Barrera", 351159380);
        public static Cliente Cliente3 { get; set; } = new Cliente(44854361, "Emilio Galimberti", 3519865210);
        public static Cliente Cliente4 { get; set; } = new Cliente(44128649, "Lucas Piccino", 3516468193);
        public static Cliente Cliente5 { get; set; } = new Cliente(43719840, "Martina Boatti", 3513901979);

        // ESTADOS
        public static Estado EstadoFinalizada { get; set; } = new Estado("Finalizada");
        public static Estado EstadoIniciada { get; set; } = new Estado("Iniciada");
        public static Estado EstadoCancelada { get; set; } = new Estado("Cancelada");

        // RESPUESTAS POSIBLES
        public static RespuestaPosible ResPos1 { get; set; } = new RespuestaPosible("SI", 1);
        public static RespuestaPosible ResPos2 { get; set; } = new RespuestaPosible("NO", 0);
        public static RespuestaPosible ResPos3 { get; set; } = new RespuestaPosible("SI", 1);
        public static RespuestaPosible ResPos4 { get; set; } = new RespuestaPosible("NO", 0);
        public static RespuestaPosible ResPos5 { get; set; } = new RespuestaPosible("SI", 1);
        public static RespuestaPosible ResPos6 { get; set; } = new RespuestaPosible("NO", 0);
        public static RespuestaPosible ResPos7 { get; set; } = new RespuestaPosible("SI", 1);
        public static RespuestaPosible ResPos8 { get; set; } = new RespuestaPosible("NO", 0);
        public static RespuestaPosible ResPos9 { get; set; } = new RespuestaPosible("SI", 1);
        public static RespuestaPosible ResPos10 { get; set; } = new RespuestaPosible("NO", 0);
        public static RespuestaPosible ResPos11 { get; set; } = new RespuestaPosible("SI", 1);
        public static RespuestaPosible ResPos12 { get; set; } = new RespuestaPosible("NO", 0);
        public static RespuestaPosible ResPos13 { get; set; } = new RespuestaPosible("Muy insatisfecho", 0);
        public static RespuestaPosible ResPos14 { get; set; } = new RespuestaPosible("Neutral", 1);
        public static RespuestaPosible ResPos15 { get; set; } = new RespuestaPosible("Muy satisfecho", 2);
        public static RespuestaPosible ResPos16 { get; set; } = new RespuestaPosible("Muy lento", 0);
        public static RespuestaPosible ResPos17 { get; set; } = new RespuestaPosible("Normal", 1);
        public static RespuestaPosible ResPos18 { get; set; } = new RespuestaPosible("Muy rápido", 2);
        public static RespuestaPosible ResPos19 { get; set; } = new RespuestaPosible("Masculino", 0);
        public static RespuestaPosible ResPos20 { get; set; } = new RespuestaPosible("Femenino", 1);
        public static RespuestaPosible ResPos21 { get; set; } = new RespuestaPosible("Otro", 2);
        public static RespuestaPosible ResPos22 { get; set; } = new RespuestaPosible("Prefiero no decirlo", 3);

        // LISTAS DE RESPUESTAS
        static List<RespuestaPosible> lisRes1 = new List<RespuestaPosible> { ResPos1, ResPos2 };
        static List<RespuestaPosible> lisRes2 = new List<RespuestaPosible> { ResPos3, ResPos4 };
        static List<RespuestaPosible> lisRes3 = new List<RespuestaPosible> { ResPos5, ResPos6 };
        static List<RespuestaPosible> lisRes4 = new List<RespuestaPosible> { ResPos7, ResPos8 };
        static List<RespuestaPosible> lisRes5 = new List<RespuestaPosible> { ResPos9, ResPos10 };
        static List<RespuestaPosible> lisRes6 = new List<RespuestaPosible> { ResPos11, ResPos12 };
        static List<RespuestaPosible> lisRes7 = new List<RespuestaPosible> { ResPos13, ResPos14, ResPos15 };
        static List<RespuestaPosible> lisRes8 = new List<RespuestaPosible> { ResPos16, ResPos17, ResPos18 };
        static List<RespuestaPosible> lisRes9 = new List<RespuestaPosible> { ResPos19, ResPos20, ResPos21, ResPos22 };

        // PREGUNTAS
        public static Pregunta Preg1 { get; set; } = new Pregunta("Se pudo solucionar su consulta?", lisRes1);
        public static Pregunta Preg2 { get; set; } = new Pregunta("Es la primera vez que llama?", lisRes2);
        public static Pregunta Preg3 { get; set; } = new Pregunta("Qué tan rápida fue la solución?", lisRes8);
        public static Pregunta Preg4 { get; set; } = new Pregunta("El operador parecía estar interesado en ayudarle?", lisRes3);
        public static Pregunta Preg5 { get; set; } = new Pregunta("El operador le trató respetuosamente?", lisRes4);
        public static Pregunta Preg6 { get; set; } = new Pregunta("Con qué sexo se identifica?", lisRes9);
        public static Pregunta Preg7 { get; set; } = new Pregunta("El operador atendió rápido su llamado?", lisRes5);
        public static Pregunta Preg2 { get; set; } = new Pregunta("Volvería a utilizar servicios de nuestra empresa?", lisRes6);
        public static Pregunta Preg2 { get; set; } = new Pregunta("Qué tan satisfecho está con la atención del operador?", lisRes7);

        // LISTA DE PREGUNTAS
        static List<Pregunta> lisPreg1 = new List<Pregunta> { Preg1, Preg2, Preg8 };
        static List<Pregunta> lisPreg2 = new List<Pregunta> { Preg3, Preg4, Preg9 };
        static List<Pregunta> lisPreg3 = new List<Pregunta> { Preg5, Preg6, Preg7 };

        // ENCUESTAS
        public static Encuesta Encuesta1 { get; set; } = new Encuesta("Solución de consulta", new DateTime(2024, 5, 26), lisPreg1);
        public static Encuesta Encuesta2 { get; set; } = new Encuesta("Sobre el cliente", new DateTime(2024, 5, 24), lisPreg2);
        public static Encuesta Encuesta3 { get; set; } = new Encuesta("Sobre el operador", new DateTime(2024, 5, 22), lisPreg3);

        // RESPUESTAS DEL CLIENTE
        public static RespuestaCliente resCli1 { get; set; } = new RespuestaCliente(new DateTime(2023, 5, 27), ResPos1);
        public static RespuestaCliente resCli2 { get; set; } = new RespuestaCliente(new DateTime(2023, 5, 27), ResPos3);
        public static RespuestaCliente resCli3 { get; set; } = new RespuestaCliente(new DateTime(2023, 5, 27), ResPos17);
        public static RespuestaCliente resCli4 { get; set; } = new RespuestaCliente(new DateTime(2023, 5, 24), ResPos6);
        public static RespuestaCliente resCli5 { get; set; } = new RespuestaCliente(new DateTime(2023, 5, 24), ResPos7);
        public static RespuestaCliente resCli6 { get; set; } = new RespuestaCliente(new DateTime(2023, 5, 24), ResPos22);
        public static RespuestaCliente resCli7 { get; set; } = new RespuestaCliente(new DateTime(2023, 5, 20), ResPos9);
        public static RespuestaCliente resCli8 { get; set; } = new RespuestaCliente(new DateTime(2023, 5, 20), ResPos11);
        public static RespuestaCliente resCli9 { get; set; } = new RespuestaCliente(new DateTime(2023, 5, 20), ResPos15);

        // LISTA DE RESPUESTAS DEL CLIENTE
        private static List<RespuestaCliente> lisCli1 = new List<RespuestaCliente> { resCli1, resCli2, resCli3 };
        private static List<RespuestaCliente> lisCli2 = new List<RespuestaCliente> { resCli4, resCli5, resCli6 };
        private static List<RespuestaCliente> lisCli3 = new List<RespuestaCliente> { resCli7, resCli8, resCli9 };

        // CAMBIOS DE ESTADO
        public static CambioEstado Cambio1Llamada1 { get; set; } = new CambioEstado(new DateTime(2023, 5, 27), new DateTime(2023, 5, 27), EstadoIniciada);
        public static CambioEstado Cambio2Llamada1 { get; set; } = new CambioEstado(new DateTime(2023, 5, 27), new DateTime(2023, 5, 27), EstadoFinalizada);
        public static CambioEstado Cambio1Llamada2 { get; set; } = new CambioEstado(new DateTime(2023, 5, 24), new DateTime(2023, 5, 24), EstadoIniciada);
        public static CambioEstado Cambio2Llamada2 { get; set; } = new CambioEstado(new DateTime(2023, 5, 24), new DateTime(2023, 5, 24), EstadoFinalizada);
        public static CambioEstado Cambio1Llamada3 { get; set; } = new CambioEstado(new DateTime(2023, 5, 20), new DateTime(2023, 5, 20), EstadoIniciada);
        public static CambioEstado Cambio2Llamada3 { get; set; } = new CambioEstado(new DateTime(2023, 5, 20), new DateTime(2023, 5, 20), EstadoFinalizada);
        public static CambioEstado Cambio1Llamada4 { get; set; } = new CambioEstado(new DateTime(2023, 5, 26), new DateTime(2023, 5, 26), EstadoIniciada);
        public static CambioEstado Cambio2Llamada4 { get; set; } = new CambioEstado(new DateTime(2023, 5, 26), new DateTime(2023, 5, 26), EstadoFinalizada);
        public static CambioEstado Cambio1Llamada5 { get; set; } = new CambioEstado(new DateTime(2023, 5, 21), new DateTime(2023, 5, 21), EstadoIniciada);
        public static CambioEstado Cambio2Llamada5 { get; set; } = new CambioEstado(new DateTime(2023, 5, 21), new DateTime(2023, 5, 21), EstadoCancelada);

        // LISTA DE CAMBIOS DE ESTADO
        static List<CambioEstado> lisCam1 = new List<CambioEstado> { Cambio1Llamada1, Cambio2Llamada1 };
        static List<CambioEstado> lisCam2 = new List<CambioEstado> { Cambio1Llamada2, Cambio2Llamada2 };
        static List<CambioEstado> lisCam3 = new List<CambioEstado> { Cambio1Llamada3, Cambio2Llamada3 };
        static List<CambioEstado> lisCam4 = new List<CambioEstado> { Cambio1Llamada4, Cambio2Llamada4 };
        static List<CambioEstado> lisCam5 = new List<CambioEstado> { Cambio1Llamada5, Cambio2Llamada5 };

        // LLAMADAS
        public static Llamada Llamada1 { get; set; } = new Llamada(lisCam1, lisCli1, Cliente1, "descripcion generica 1",
            "detalle generico 1", 150, true, "Voz poco clara del operador");
        public static Llamada Llamada2 { get; set; } = new Llamada(lisCam2, lisCli2, Cliente3, "descripcion generica 2",
            "detalle generico 2", 95, true, "Incorrecto trato al cliente");
        public static Llamada Llamada3 { get; set; } = new Llamada(lisCam3, lisCli3, Cliente5, "descripcion generica 3",
            "detalle generico 3", 82, true, "No requiere registrar observación");
        public static Llamada Llamada4 { get; set; } = new Llamada(lisCam4, null, Cliente2, "descripcion generica 4",
            "detalle generico 4", 175, false, "No requiere registrar observación");
        public static Llamada Llamada5 { get; set; } = new Llamada(lisCam5, null, Cliente4, "descripcion generica 5",
            "detalle generico 5", 25, false, "Cancela la llamada");
    }
}
