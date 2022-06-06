using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Hacer una función que calcule el factorial de un número.

namespace Ejercicio_4_Cap5
{
    class Program
    {
       
        public static void factorial(int numero)
        {
            double factorial;  
            factorial = 1;  

       
            if (numero == 0) factorial = 1;   
            else for (int i = 1; i <= numero; i++) factorial *= i;  

            Console.WriteLine("\t{0}! = {1}\n", numero, factorial);
        }

 
        public static int validarValorEntero()
        {
            int valor;
            while ((!Int32.TryParse(Console.ReadLine(), out valor)) || (valor < 0) || (valor > 170)) 
            {
                Console.WriteLine(" [ERROR]: Valor invalido, vuelva a interntar.\n");   
            }
            return valor;  
        }

        //Funcion Principal
        static void Main(string[] args)
        {
           
            char opcion = 'y';
            int num;
 
            while (opcion != 'n')
            {
                num = 0;

                //Impresion titulo
                Console.WriteLine("          Calculo de Factorial de un Numero   ");
                Console.WriteLine("-------------------------------------------------");
              
                Console.Write(" Ingrese un numero:");
                num = validarValorEntero(); 
                Console.WriteLine("");

                factorial(num); 
                
                Console.Write("\n ¿Deseas calcular otro factorial? [y/n]: "); 

                while (!((Char.TryParse(Console.ReadLine().ToLower(), out opcion)) && ((opcion == 'n') || (opcion == 'y'))))
                    Console.Write("\n ¿Deseas calcular otro factorial? [y/n]: ");

                Console.Clear();
            }
        }
    }
}