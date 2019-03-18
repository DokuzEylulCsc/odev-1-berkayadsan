using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp17
{
    
   abstract class Asker
    {
        
        
        private Bolge koordinat;
        public Bolge Koordinat {
            

        get { return koordinat; }
        }
        public int xNoktasi = 0;
        public  int  yNoktasi = 0;

        public string takimbilgisi;
        public int saglikmiktari=100;
        private bool yasiyor = true;
        public void Yasiyor()
        {
            while (saglikmiktari > 0 && saglikmiktari<=100)
            {
                yasiyor = true;

            }
            if (saglikmiktari==0)
            {
                yasiyor = false;
                
            }
        }
        public abstract void HareketEt(Bolge[,] map);
        public abstract void Bekle();
        public abstract void AtesEt(Bolge[,] map);
       
        
            public static void DosyayaYazdir(string hamle)
            {
                string dosya_yolu = @"C:\AskerHamleleri.txt";
                FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(hamle);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        
    }
}
