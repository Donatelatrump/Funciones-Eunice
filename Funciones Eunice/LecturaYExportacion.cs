using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones_Eunice
{
    internal class LecturaYExportacion
    {

        public string ReadTextFile(string filePath)
        {
            try
            {
                // Lee el contenido del archivo de texto
                string content = File.ReadAllText(filePath);
                // Retorna el contenido leído como una cadena de caracteres
                return content;
            }
            catch (Exception ex)
            {
                // Si ocurre un error durante la lectura del archivo, se muestra un mensaje de error
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
                return "";
            }

        }

        public void WriteTextToFile(string filePath, string text)
        {
            try
            {
                // Escribe el texto en el archivo
                File.WriteAllText(filePath, text);

                Console.WriteLine("El texto se ha escrito correctamente en el archivo.");
            }
            catch (Exception ex)
            {
                // Si ocurre un error durante la escritura del archivo, se muestra un mensaje de error
                MessageBox.Show("Error al escribir en el archivo: " + ex.Message);
            }
        }


    }
}
