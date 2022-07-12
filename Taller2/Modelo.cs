using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    class Modelo
    {
        private int numModelo;
        private int numPreguntas;
        private string respuesta;
        private static Random random = new Random();

        public Modelo(int numModelo, string respuesta)
        {
            this.numModelo = numModelo;
            this.respuesta = respuesta;
        }

        public Modelo(int numModelo, int numPreguntas)
        {
            this.numModelo = numModelo;
            this.numPreguntas = numPreguntas;
            generarRespuestaCorrecta();
        }

        public Modelo(int numModelo)
        {
            this.numModelo = numModelo;
            this.numPreguntas = generarNumPreguntas();
            generarRespuestaCorrecta();
        }

        public int generarNumPreguntas()
        {
            int preguntas = 0;
            Random rand = new Random();
            preguntas = rand.Next(4,12);
            return preguntas;
        }

        public void generarRespuestaCorrecta()
        {
            
            string[] opciones = {"a", "b", "c", "d"};
                for (int i = 0; i < numPreguntas; i++)
                {
                    this.respuesta += opciones[random.Next(4)];
                }
      
        }

        public override string ToString()
        {
            return "Modelo n°: " + this.numModelo + "\n"
                + "N° preguntas: " + this.numPreguntas + "\n"
                + "Respuesta: " + respuesta + "\n";
        }

        public int getNumModelo()
        {
            return numModelo;
        }

        public int getNumPreguntas()
        {
            return numPreguntas;
        }

        public string getRespuesta()
        {
            return respuesta;
        }

    }
}
