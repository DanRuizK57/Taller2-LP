using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Taller2
{
    class ListaTest
    {
        public TextReader leer;
        public TextWriter escribir;

        public ListaTest()
        {
            this.leer = new StreamReader(@"..\..\..\entrada_datos.txt");
            this.escribir = File.AppendText(@"..\..\..\salida_datos.txt");
        }

        public void leerArchivo()
        {
            List<string> palabras = new List<string>();
            foreach (string line in System.IO.File.ReadLines(@"..\..\..\entrada_datos.txt"))
            {
                palabras.Add(line);
                System.Console.WriteLine(line);
            }
        }

        public void escribirArchivo()
        {
            

            escribir.WriteLine("Nombre Alumno             Puntos");
            escribir.Close();
        }

    }
}
