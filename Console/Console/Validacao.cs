using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Validacao
    {
        public static string ValidaStringEmBranco()
        {
            string dado = System.Console.ReadLine().Trim();
            while (String.IsNullOrEmpty(dado))
            {
                System.Console.WriteLine("Valor invalido");
                dado = System.Console.ReadLine().Trim();
            }
            return dado;
        }
        public static int ValidaInteiros()
        {
            do
            {
                try
                {
                    int dado = Convert.ToInt32(System.Console.ReadLine());
                    return dado;
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("Dado invalido");
                }
            } while (true);
        }

    }
}
