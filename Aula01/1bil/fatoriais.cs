using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bil
{
    public class fatoriais
    {
        public fatoriais()
        {
            Console.WriteLine("Fatoriais de 1 até 10:");

            for (int i = 1; i <= 10; i++)
            {
                long resultado = CalcularFatorial(i);
                Console.WriteLine($"{i}! = {resultado}");
            }
        }
    }
}