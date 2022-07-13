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

            Test test = new Test();

            test.AgregarModelos(modelos);
            foreach (Modelo modelo in modelos) 
                Console.WriteLine(modelo.ToString());

            SimTest simtest = new SimTest(test);
            test.ContarModelos();

            Console.WriteLine("Ingrese el n° de alumnos para simular");
            int opcion = Int32.Parse(Console.ReadLine());

            simtest.Simula(opcion);
            simtest.ImprimirAlumnos();
            simtest.Listado();

            ListaTest lt = new ListaTest();
            lt.LeerArchivo();
            lt.SimularArchivo();
            lt.EscribirArchivo();

            Console.ReadLine();

        }
    }
}
