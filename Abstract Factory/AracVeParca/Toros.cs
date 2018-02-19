using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Model
{
    class Toros : AAraba
    {
        public override void Calıstır()
        {
            Console.WriteLine("Toros Çalıştı");
        }

        public override void Durdur()
        {
            Console.WriteLine("Toros Durdu");
        }

        
    }
}
