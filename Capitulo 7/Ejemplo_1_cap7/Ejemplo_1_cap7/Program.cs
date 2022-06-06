using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1_cap7
{
    /// 1 Hacer el programa que calcula el promedio, calificación máxima y mínimade un salón de clases usando el ArrayList.

    class SalonClases
    {

        public static void Main(string[] args)
        {
            ArrayList estudiantes = new ArrayList();
            string valor;
            int maxima = 0, minima = 100, suma = 0, promedio;

            do
            {
                Console.WriteLine("Digite una calificacion <Para terminar digite un punto(.)");
                valor = Console.ReadLine();
                if (valor == ".") { break; }
                estudiantes.Add(Convert.ToInt32(valor));
            } while (valor != ".");

            foreach (int calificacion in estudiantes)
            {
                if (calificacion > maxima)
                    maxima = calificacion;

                if (calificacion < minima)
                    minima = calificacion;

                suma += calificacion;
            }

            promedio = suma / estudiantes.Count;

            Console.WriteLine("El promedio es {0}, la calificacion minima {1} y la maxima{2}", promedio, minima, maxima);
        }
    }
}
