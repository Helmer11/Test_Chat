using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.Models
{
    internal class ChatFileBot
    {
        public ChatFileBot()
        {
            
        }


        public string AnalizarArchivo(string archivo)
        {
            System.IO.StreamReader arch = new System.IO.StreamReader(archivo);
            string separador = ",";
            string linea;
            string cadenaResultado = "";

            arch.ReadLine(); // Leer la primera línea pero descartarla porque es el encabezado
            while ((linea = arch.ReadLine()) != null)
            {
                string[] fila = linea.Split(separador);
                string Open = fila[0];
                double High = Convert.ToDouble(fila[1]);
                double Low = Convert.ToDouble(fila[2]);
                double close = Convert.ToDouble(fila[3]);

                cadenaResultado = String.Format("Open {0} con High {1} Low {2} y Close {3}", Open, High, Low, close);
                
            }
            return cadenaResultado;
        }


    }
}
