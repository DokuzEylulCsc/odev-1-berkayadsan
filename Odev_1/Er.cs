using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    
    class Er:Asker
    {
        public Er (int x,int y)
        {
            xNoktasi = x;
            yNoktasi = y;
            
        }
        
        public override void HareketEt(Bolge[,] map)
        {
            Random rnd = new Random();
            int yEr = rnd.Next(0, 2);
            bool c1 = false;
            
            while (!c1)
            {
                c1 = true;
                yEr = rnd.Next(0, 2);
                if (yEr == 0)
                    c1 = false;
            }
            if (map[xNoktasi, yNoktasi]==null )
            {
                yNoktasi++;
                c1 = true;
            }

        }

        public override void Bekle()
        {
            Console.WriteLine("Er bekliyor");
        }

        public override void AtesEt(Bolge[,] map)
        {

        }

        
    }
}
