using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea2
{
    /// 5 Hacer un programa que le solicite al usuario dos cadenas y luego las muestre en orden alfabético.
    
    class Cadenas
    {

        public static void Main(string[] args)
        {
            string cadena1, cadena2;
            int comparacion;

            Console.WriteLine("Digite la cadena 1");
            cadena1 = Console.ReadLine();
            Console.WriteLine("Digite la cadena 2");
            cadena2 = Console.ReadLine();

            comparacion = String.Compare(cadena1, cadena2);
            Console.Clear();
            if (comparacion > 0)
                Console.WriteLine(cadena2 + "  " + cadena1);
            else
                Console.WriteLine(cadena1 + "  " + cadena2);

        }
    }
}