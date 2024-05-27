using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de jugadores: ");
            int numJugadores = Convert.ToInt16(Console.ReadLine());
            string jMenorMonto = "";
            double menorMonto = 90000;
            string jMayorMonto = "";
            double mayorMonto = 0;
            for (int i = 0; i < numJugadores; i++)
            {
                Console.Write($"Ingrese el nombre del jugador {i}: ");
                string nombre = Console.ReadLine();
                Console.Write($"Ingrese el monto promedio de apuestas para {nombre}: ");
                double monto = Convert.ToSingle(Console.ReadLine());

                if (monto < menorMonto)
                {
                    jMenorMonto = nombre;
                    menorMonto = monto;
                }
                if (monto > mayorMonto)
                {
                    jMayorMonto = nombre;
                    mayorMonto = monto;
                }
            }
            Console.WriteLine($"El jugador con el menor promedio de apuestas es: {jMenorMonto} con un promedio de: {menorMonto}");
            Console.WriteLine($"El jugador con el mayor promedio de apuestas es: {jMayorMonto} con un promedio de: {mayorMonto}");
            Console.ReadKey();
        }
    }
}