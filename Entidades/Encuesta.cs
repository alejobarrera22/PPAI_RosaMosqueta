using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Entidades
{
    public class Encuesta
    {
        private string descripcion { get; set; }
        private DateTime fechaFinVigencia { get; set; }
        private List<Pregunta> preguntas { get; set; }


        // el constructor para la clase Encuesta con una lista de preguntas inicialmente vacia
        public Encuesta(string descripcion, DateTime fechaFinVigencia, List<Pregunta> pregunts)
        {
            this.descripcion = descripcion;
            this.fechaFinVigencia = fechaFinVigencia;
            this.preguntas = pregunts;
        }

        // entiendo como si fuera de agregar las preguntas a la encuesta
        // no nos importa no es este nuestro caso de uso
        public void armarEncuesta(Pregunta pregunta)
        {
            preguntas.Add(pregunta);
        }

        // jamas sabremos para que es este metodo
        public bool esEncuestaDeCliente() { }

        // esta fecha actual se la tiene que pasar el controlador
        public bool esVigente(DateTime fechaActual)
        {
            if (fechaFinVigencia < fechaActual) { return true; }
            else { return false; }
        }

        // getter de la descripcion de la encuesta
        public string getDescripcionEncuesta() { return descripcion; }

        // getter de sabra dios que cosa en un caso de uso que no es el nuestro
        //public string esDescripcionDeCliente() { }

        public List<Pregunta> getPreguntas() { return preguntas; }
    }
}