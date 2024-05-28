using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int nroL = 0;
            int nota = 0;
            string nombMayor = "";
            string nombMenor = "";
            int libMayor = 0;
            int libMenor = 0;
            int mayor = 0;
            int menor = 999;
            Console.WriteLine("ingrese la cantidad de alumnos");
            int alumnos = Convert.ToInt16(Console.ReadLine());
            for (int i=1; i<=alumnos; i++)
            {
                Console.WriteLine("Ingrese el numero de libreta, el nombre y la nota");
                nroL = Convert.ToInt32(Console.ReadLine());
                nombre = Console.ReadLine();
                nota = Convert.ToInt16(Console.ReadLine());
                if (nota>mayor)
                {
                    libMayor = nroL;
                    nombMayor = nombre;
                    mayor = nota;
                }
                if (nota < menor)
                {
                    libMenor = nroL;
                    nombMenor = nombre;
                    menor = nota;
                }
            }
            Console.WriteLine($"El alumno con la mayor nota es {libMayor} {nombMayor}");
            Console.WriteLine($"El alumno con la menor nota es {libMenor} {nombMenor}");
            Console.ReadKey();
        }
    }
}
