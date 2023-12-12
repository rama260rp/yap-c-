using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapıcı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program başladı");
            Kisi k = new Kisi();
            Console.WriteLine("adı={0},yaşı{1},k.yas,k.ad");
            Console.WriteLine("Program bitti");
        }
    }
    class Kisi
    {
        int yas;
        string ad;
        public Kisi()
        {
            yas = 19;
            ad = "Ahmet";
            Console.WriteLine("Yapıcı metot çalıştı.");
        }
        public int Yas
        {
            get
            {
                return yas;
            }
        }
        public string Ad
        {
            get
            {
                return ad;
            }
        }
    }
}
