using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Model;

namespace Abstract_Factory.Model
{
    class AnadolFabrikasi : Abstract_Factory.Model.AFactory
    {
        public override AAraba ArabaYap()
        {
           return new Anadol();
        }

        public override AParca ParcaYap()
        {
            return new AnadolParca("Ayna"); ;
        }
    }
}
