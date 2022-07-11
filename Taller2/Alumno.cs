using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    class Alumno
    {
        private string nombreAlumno;
        private int numModelo;
        private string respuesta;

        public Alumno(string nombreAlumno, int numModelo, string respuesta)
        {
            this.nombreAlumno = nombreAlumno;
            this.numModelo = numModelo;
            this.respuesta = respuesta;
        }

        public int corrige(Test test)
        {
           return test.corrigeModelo(this.numModelo, this.respuesta);
        }

        public override string ToString()
        {
            return "Nombre Alumno: " + nombreAlumno + "\n"
                + "N° Modelo: " + numModelo + "\n"
                + "Respuesta: " + respuesta + "\n";
        }
    }
}
