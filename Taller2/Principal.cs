using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    class Principal
    {
        static void Main(string[] args)
        {
            List<Modelo> modelos = new List<Modelo>();
            Console.WriteLine("Ingrese el n° de modelos de la prueba: ");
            int eleccion = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < eleccion; i++)
            {
                modelos.Add(new Modelo(i+1));
            }

            /*Modelo m1 = new Modelo(1,6);
            Console.WriteLine(m1.ToString());

            Modelo m2 = new Modelo(2,6);
            Console.WriteLine(m2.ToString());

            Modelo m3 = new Modelo(3,6);
            Console.WriteLine(m3.ToString());

            Modelo m4 = new Modelo(4,6);
            Console.WriteLine(m4.ToString());*/

            Test test = new Test();
            /*test.agregarModelo(m1);
            test.agregarModelo(m2);
            test.agregarModelo(m3);
            test.agregarModelo(m4); */
            test.agregarModelos(modelos);
            foreach (Modelo modelo in modelos) {Console.WriteLine(modelo.ToString());}



            int puntos = test.corrigeModelo(1, "a bcad");
            Console.WriteLine("Puntos: " + puntos);

            Alumno a1 = new Alumno("Juan",1,"cadbcb");
            Console.WriteLine("Puntos a1: " + a1.corrige(test) + "\n");

            SimTest simtest = new SimTest(test);
            test.contarModelos();

            Console.WriteLine("Ingrese el n° de alumnos para simular");
            int opcion = Int32.Parse(Console.ReadLine());

            simtest.simula(opcion);
            simtest.imprimirAlumnos();
            simtest.listado();

            Console.ReadLine();

        }
    }
}
