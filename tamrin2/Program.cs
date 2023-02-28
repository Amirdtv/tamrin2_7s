using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[3, 3];
            int cont = 0;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("adad bezanid ");
                    x[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            cont = x[0, 0] * ((x[1, 1] * x[2, 2]) - (x[2, 1] * x[1, 2])) - x[0, 1] * ((x[1, 0] * x[2, 2]) - (x[1, 2] * x[2, 0])) + x[0, 2] * ((x[1, 0] * x[2, 1]) - (x[2, 0] * x[1,1]));
            Console.Write("javab = ");
            Console.WriteLine(cont);
        }
    }
}
