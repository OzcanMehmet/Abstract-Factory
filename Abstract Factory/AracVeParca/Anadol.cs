using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Model
{
    public class Anadol : Abstract_Factory.Model.AAraba
    {
        public override void Calıstır()
        {
            Console.WriteLine("Anadol Çalıştı");
        }

        public override void Durdur()
        {
            Console.WriteLine("Anadol Durdu");
        }
    }
}
