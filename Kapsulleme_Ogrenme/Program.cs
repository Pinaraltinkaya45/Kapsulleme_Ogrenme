using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme_Ogrenme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.setIsim("Pınar");
            string gelenisim = ogrenci1.getIsim();


            if(gelenisim == "Pınar")
            {
                Console.WriteLine("Doğru Giriş Yaptınız");
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız");
            }

            Console.ReadLine();
            
        }
    }
}
