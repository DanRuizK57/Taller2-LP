using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    class Test
    {
        private List<Modelo> modelos;
        private int cantidadModelos;
        public Test ()
        {
            this.modelos = new List<Modelo> ();
            this.cantidadModelos = 0;
        }

        public void agregarModelo(Modelo m)
        {
            modelos.Add(m);
        }

        public void agregarModelos(List<Modelo> m)
        {
            this.modelos = m;
        }

        public void contarModelos()
        {
            this.cantidadModelos = modelos.Count();
        }

        public int corrigeModelo(int num_modelo, string respuesta_modelo)
        {
            int puntos = 0;

            Modelo pautaModelo = reconocerModelo(num_modelo, respuesta_modelo);

            char[] respuestasPauta = pautaModelo.getRespuesta().ToCharArray();
            char[] respuestasContestadas = respuesta_modelo.ToCharArray();

            for (int i = 0; i < pautaModelo.getNumPreguntas(); i++)
            {
                    if (respuestasPauta[i] == respuestasContestadas[i])
                    {
                        puntos += 3;
                    }
                    else if (respuestasPauta[i] != respuestasContestadas[i] && respuestasContestadas[i] == ' ')
                    {
                        puntos += 0;
                    }
                    else
                    {
                        puntos -= 1;
                    }
            }
            return puntos;

        }

        public Modelo reconocerModelo(int num_modelo, string respuesta_modelo)
        {
            for (int i = 0; i < modelos.Count; i++)
            {
                if (num_modelo == modelos[i].getNumModelo())
                {
                    return modelos[i];
                }
               
            }
            return null;
            
        }

        public int getCantidadModelos()
        {
            return cantidadModelos;
        }

        public List<Modelo> getModelos()
        {
            return modelos;
        }
    }
}
