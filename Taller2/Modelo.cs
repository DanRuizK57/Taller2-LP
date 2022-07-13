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
            GenerarRespuestaCorrecta();
        }

        public Modelo(int numModelo)
        {
            this.numModelo = numModelo;
            this.numPreguntas = GenerarNumPreguntas();
            GenerarRespuestaCorrecta();
        }

        public int GenerarNumPreguntas()
        {
            int preguntas = 0;
            Random rand = new Random();
            preguntas = rand.Next(4,12);
            return preguntas;
        }

        public void GenerarRespuestaCorrecta()
        {
            
            string[] opciones = {"a", "b", "c", "d"};
                for (int i = 0; i < numPreguntas; i++)
                {
                    this.respuesta += opciones[random.Next(4)].ToLower();
                }
      
        }

        public override string ToString()
        {
            return "Modelo n°: " + this.numModelo + "\n"
                + "N° preguntas: " + this.numPreguntas + "\n"
                + "Respuesta: " + respuesta + "\n";
        }

        public int GetNumModelo()
        {
            return numModelo;
        }

        public int GetNumPreguntas()
        {
            return numPreguntas;
        }

        public string GetRespuesta()
        {
            return respuesta;
        }

    }
}
