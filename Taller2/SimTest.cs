using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    class SimTest
    {
        private List<Alumno> alumnos;
        private Test test;
        private List<Modelo> modelos;
        private static Random random = new Random();
        public SimTest(Test test)
        {
            this.alumnos = new List<Alumno>();
            this.test = test;
            this.modelos = test.GetModelos();
        }

        public void Simula(int numAlumnos)
        {
            Random rand = new Random();
            int modeloElegido = 0;
            Modelo m;
            string respuesta = "";

            for (int i = 0; i < numAlumnos; i++)
            {
                modeloElegido = rand.Next(1, modelos.Count());
                m = SeleccionarModelo(modeloElegido);
                respuesta = GenerarRespuesta(m);

                alumnos.Add(new Alumno(GenerarNombre(i+1), modeloElegido, respuesta));
            }
        }

        public void Listado()
        {
            List<int> puntuaciones = new List<int>();
            for (int i = 0; i < alumnos.Count(); i++)
            {
                puntuaciones.Add(alumnos[i].Corrige(test));
            }
            var contador = new List<Tuple<int, int>>();
            bool encontro;
            foreach (int x in puntuaciones)
            {
                encontro = false;
                for (int i = 0; i < contador.Count; i++)
                    if (contador[i].Item1 == x)
                    {
                        encontro = true;
                        contador[i] = new Tuple<int, int>(contador[i].Item1, contador[i].Item2 + 1);
                    }

                if (!encontro)
                {
                    contador.Add(new Tuple<int, int>(x, 1));
                }

            }
            Console.WriteLine("Puntuaciones    Num. Alumnos");
            contador.Sort();
            for (int i = 0; i < contador.Count; i++) { 
                Console.WriteLine("      " + contador[i].Item1 + "               " + contador[i].Item2);
            }
        }

        public string GenerarNombre(int numAlumno)
        {
            string nombre = "NOMBRE" + numAlumno;
            return nombre;
        }

        public string GenerarRespuesta(Modelo m)
        {
            string respuesta = "";
            string[] opciones = { "a", "b", "c", "d", " "};
            for (int i = 0; i < m.GetNumPreguntas(); i++)
            {
                respuesta += opciones[random.Next(5)];
            }
            return respuesta;
        }

        public Modelo SeleccionarModelo(int numModeloElegido)
        {
            for (int i = 0; i < modelos.Count(); i++)
            {
                if (modelos[i].GetNumModelo() == numModeloElegido)
                {
                    return modelos[i];
                }
            }
            return null;
        }

        public void ImprimirAlumnos()
        {
            foreach (Alumno a in alumnos) { Console.WriteLine(a.ToString()); }
        }

    }
}
