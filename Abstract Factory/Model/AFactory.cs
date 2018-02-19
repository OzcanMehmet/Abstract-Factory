using Abstract_Factory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Model
{
    public abstract class  AFactory
    {
        public abstract AAraba ArabaYap();
        public abstract AParca ParcaYap();
    }
}
