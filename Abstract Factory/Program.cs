using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Model;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            AFactory myfactory=FabrikaGetir("Anadol");
            AAraba mycar = myfactory.ArabaYap();
            AParca parca = myfactory.ParcaYap();
            mycar.Calıstır();
            mycar.Durdur();
            Console.WriteLine(parca.GetName());
             


            myfactory = FabrikaGetir("Toros");
            mycar = myfactory.ArabaYap();
            parca = myfactory.ParcaYap();
            mycar.Calıstır();
            mycar.Durdur();
            Console.WriteLine(parca.GetName());

            Console.ReadLine();

        }
        public static Abstract_Factory.Model.AFactory  FabrikaGetir(string fabrikaismi)
        {
            switch (fabrikaismi)
            {
                case "Toros":   return new TorosFabrikasi(); break;
                case "Anadol":  return new AnadolFabrikasi(); break;
                default: return null;
            }
        }
    }
}
