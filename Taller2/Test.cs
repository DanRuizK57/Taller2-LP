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

        public void AgregarModelo(Modelo m)
        {
            modelos.Add(m);
        }

        public void AgregarModelos(List<Modelo> m)
        {
            this.modelos = m;
        }

        public void ContarModelos()
        {
            this.cantidadModelos = modelos.Count();
        }

        public int corrigeModelo(int num_modelo, string respuesta_modelo)
        {
            int puntos = 0;

            Modelo pautaModelo = ReconocerModelo(num_modelo);

            char[] respuestasPauta = pautaModelo.GetRespuesta().ToCharArray();
            char[] respuestasContestadas = respuesta_modelo.ToCharArray();

            for (int i = 0; i < pautaModelo.GetNumPreguntas(); i++)
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

        public Modelo ReconocerModelo(int num_modelo)
        {
            for (int i = 0; i < modelos.Count(); i++)
            {
                if (num_modelo == modelos[i].GetNumModelo())
                {
                    return modelos[i];
                }
               
            }
            return null;
        }

        public int GetCantidadModelos()
        {
            return cantidadModelos;
        }

        public List<Modelo> GetModelos()
        {
            return modelos;
        }
    }
}
