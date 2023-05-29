using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PPAI_RosaMosqueta.Interfaces
{
    public class ILlamadaCSV
    {
        private string encabezado {  get; set; }
        private string datos { get; set; }
        public ILlamadaCSV(string datos, string encabezado)
        {
            this.datos = datos;
            this.encabezado = encabezado;
        }

        public void crearCSV()
        {
            // Ruta del archivo
            string ruta = "../../../encuesta.csv";

            try
            {
                // Abrir el archivo CSV para escritura
                using (StreamWriter writer = new StreamWriter(ruta))
                {
                    // Escribe el encabezado del CSV
                    writer.WriteLine("\"Nombre del Cliente\";\"Estado Actual de la llamada\";\"Duración de la llamada\"");
                    writer.WriteLine(encabezado);

                    // Escribir las líneas en el archivo CSV
                    writer.WriteLine("\n\n" + datos);


                    // Cerrar el archivo
                    writer.Close();
                    MessageBox.Show("Archivo CSV generado exitosamente");
                }

            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al generar el archivo CSV: " + ex.Message); 
            }
        }
    }
}
