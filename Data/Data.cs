using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI_RosaMosqueta.Entidades;

namespace PPAI_RosaMosqueta.Data
{
    public class Data
    {
        private List<Estado> estados;
        private List<CambioEstado> cambiosEstados;
        private List<Llamada> llamadas;
        private List<Cliente> clientes;
        private List<RespuestaCliente> respuestaClientes;
        private List<RespuestaPosible> respuestaPosibles; 
        private List<Encuesta> encuestas;
        public void generarData()
        {
            //Clientes
            Cliente cliente1 = new Cliente(44945302, "Emilio Galimberti", 380496121);
            Cliente cliente2 = new Cliente(43990147, "Alejo Barrera", 382144491);
            Cliente cliente3 = new Cliente(44854361, "Franco Ambrosini", 381236121);
            Cliente cliente4 = new Cliente(44128649, "Martina Boatti", 380521121);

            clientes = new List<Cliente>() { cliente1, cliente2, cliente3, cliente4 };
            //Repuestas Posibles
            RespuestaPosible respuestaPosible1 = new RespuestaPosible("Si", 1);
            RespuestaPosible respuestaPosible2 = new RespuestaPosible("No", 0);
            RespuestaPosible respuestaPosible3 = new RespuestaPosible("Muy insatisfecho", 1);
            RespuestaPosible respuestaPosible4 = new RespuestaPosible("Otro", 0);
            RespuestaPosible respuestaPosible5 = new RespuestaPosible("Muy satisfecho", 2);

            //calculo que este seria el lista repuestas
            respuestaPosibles = new List<RespuestaPosible>() { respuestaPosible1, respuestaPosible2, respuestaPosible3, respuestaPosible4, respuestaPosible5};
            //Repuestas de clientes
            RespuestaCliente respuestaCliente1 = new RespuestaCliente(new DateTime(2023,5,22), respuestaPosible1);
            RespuestaCliente respuestaCliente2 = new RespuestaCliente(new DateTime(2023, 5, 25), respuestaPosible2);
            RespuestaCliente respuestaCliente3 = new RespuestaCliente(new DateTime(2023, 5, 30), respuestaPosible3);
            RespuestaCliente respuestaCliente4 = new RespuestaCliente(new DateTime(2023, 6, 1), respuestaPosible4);
            RespuestaCliente respuestaCliente5 = new RespuestaCliente(new DateTime(2023, 6, 5), respuestaPosible5);

            //calculo que este seria el lista repuestas
            respuestaClientes = new List<RespuestaCliente>() { respuestaCliente1, respuestaCliente2, respuestaCliente3, respuestaCliente4, respuestaCliente5};
            //Encuestas
            Encuesta encuesta1 = new Encuesta("solucion consuta", new DateTime(2023, 5, 22), respuestaPosible1);


            //Estados

            //Cambio de estado de llamada (uno por llamada

            //llamada
        }
    }
}
