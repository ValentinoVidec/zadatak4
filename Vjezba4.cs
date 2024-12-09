using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba4
{
    internal class Program
    {
        class KlasaX
        {
            int broj;

            
            private int Broj { get => broj; set => broj = value; }

            public KlasaX() { }

            public KlasaX(int broj)
            {
                this.broj = broj;
            }

            public override string ToString()
            {
                string ispis = "Vrijednost broja je " + this.broj;
                return ispis;
            }
        }
        static void Main(string[] args)
        {
            KlasaX KlasaX = new KlasaX(10);
            Console.WriteLine(KlasaX.ToString());
            Console.ReadKey();
        }
    }
}
