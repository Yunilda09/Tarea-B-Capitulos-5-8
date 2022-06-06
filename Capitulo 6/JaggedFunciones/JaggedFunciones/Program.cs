using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedFunciones
{
    class JaggedFuncion
    {
        public JaggedFuncion() { }

        public void paso(int[][] jagged)
        {
            for (int n = 0; n < jagged.Length; n++)
            {
                for (int m = 0; m < jagged[n].GetLength(0); m++)
                {
                    Console.WriteLine(jagged[n][m]);
                }

            }
        }
    }
}
