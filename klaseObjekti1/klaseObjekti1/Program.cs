using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace klaseObjekti1
{
    class Automobil
    {
        string marka;
        string brojŠasije;
        int snaga;
        int godinaProizvodnje;

        public string BrojŠasije { get => brojŠasije; set => brojŠasije = value; }
        public int Snaga { get => snaga; set => snaga = value; }
        public int GodinaProizvodnje { get => godinaProizvodnje; set => godinaProizvodnje = value; }

        public void setMarka(string marka)
        {
            this.marka = marka;
        }
        public string getMarka()
        {
            return this.marka;
        }
        public Automobil() { }

        public Automobil(string moddel, string brojŠasije, int snaga, int godinaProizvodnje) {
            this.snaga = snaga;
            this.marka = marka;
            this.godinaProizvodnje = godinaProizvodnje;
            this.BrojŠasije = brojŠasije;
        
        
        
        }

        public override string ToString()
        {
            string ispis = "Marka; " + this.marka + "\nBroj Šasije: " + this.brojŠasije + "\nSnaga: " +
                this.snaga + " KS" + "\nGodina proizvodnje: " + this.godinaProizvodnje;
            return base.ToString();
        }





    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Automobil automobil = new Automobil();
            
            automobil.setMarka("BMW");
            automobil.Snaga = 10;
            automobil.BrojŠasije = "123456ABC";
            automobil.GodinaProizvodnje = 2023;
            */


            Automobil automobil = new Automobil("BMW", "123456ABC", 150, 2023);

            Console.WriteLine(automobil.getMarka());
            Console.WriteLine(automobil.Snaga);
            Console.WriteLine(automobil.BrojŠasije);
            Console.WriteLine(automobil.GodinaProizvodnje);

            Console.WriteLine(automobil.ToString());
            Console.ReadKey();


        Console.ReadKey();
        }
    }
}
