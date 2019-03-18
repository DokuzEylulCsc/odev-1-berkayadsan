using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {

            Bolge[,] map = new Bolge[16, 16];
            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 16; j++)
                    map[i, j] = new Bolge(i, j);

           


        }
    }
}
