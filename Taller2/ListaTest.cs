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
        private TextWriter escribir;
        private List<string> palabras;
        private Test test;
        private List<Modelo> modelos;
        private List<int> puntosAlumnos;
        private List<string> nombresAlumnos;

        public ListaTest()
        {
            this.escribir = File.AppendText(@"..\..\..\salida_datos.txt");
            this.palabras = new List<string>();
            this.test = new Test();
            this.modelos = new List<Modelo>();
            this.puntosAlumnos = new List<int>();
            this.nombresAlumnos = new List<string>();
        }

        public void LeerArchivo()
        { 
            foreach (string line in File.ReadLines(@"..\..\..\entrada_datos.txt"))
            {
                palabras.Add(line);
            }
        }

        public void SimularArchivo()
        {
            int valorRespCorrecta = Int32.Parse(palabras[0]);
            int valorRespFallida = Int32.Parse(palabras[1]);
            int numModelos = Int32.Parse(palabras[2]);
            int preguntasModelos = Int32.Parse(palabras[3]);
            string respModelo1 = palabras[4];
            string respModelo2 = palabras[5];
            string respModelo3 = palabras[6];
            string respModelo4 = palabras[7];

            string[] datosAlumno1 = palabras[8].Split(':');
            int numModeloAlumno1 = Int32.Parse(datosAlumno1[0]);
            string respAlumno1 = datosAlumno1[1];
            string nombreAlumno1 = datosAlumno1[2];

            string[] datosAlumno2 = palabras[9].Split(':');
            int numModeloAlumno2 = Int32.Parse(datosAlumno2[0]);
            string respAlumno2 = datosAlumno2[1];
            string nombreAlumno2 = datosAlumno2[2];

            string[] datosAlumno3 = palabras[10].Split(':');
            int numModeloAlumno3 = Int32.Parse(datosAlumno3[0]);
            string respAlumno3 = datosAlumno3[1];
            string nombreAlumno3 = datosAlumno3[2];

            for (int i = 0; i < numModelos; i++)
            {
                modelos.Add(new Modelo((i + 1),preguntasModelos));
            }

            test.AgregarModelos(modelos);

            int puntosAlumno1 = test.corrigeModelo(numModeloAlumno1, respAlumno1.ToLower());
            int puntosAlumno2 = test.corrigeModelo(numModeloAlumno2, respAlumno2.ToLower());
            int puntosAlumno3 = test.corrigeModelo(numModeloAlumno3, respAlumno3.ToLower());

            puntosAlumnos.Add(puntosAlumno1);
            puntosAlumnos.Add(puntosAlumno2);
            puntosAlumnos.Add(puntosAlumno3);

            nombresAlumnos.Add(nombreAlumno1);
            nombresAlumnos.Add(nombreAlumno2);
            nombresAlumnos.Add(nombreAlumno3);
        }

        public void EscribirArchivo()
        {
            escribir.WriteLine("Nombre Alumno             Puntos");
            escribir.WriteLine(nombresAlumnos[0] + "        " + puntosAlumnos[0]);
            escribir.WriteLine(nombresAlumnos[1] + "        " + puntosAlumnos[1]);
            escribir.WriteLine(nombresAlumnos[2] + "        " + puntosAlumnos[2]);
            escribir.WriteLine(" ");
            escribir.Close();
        }

    }
}
