using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Model
{
    public abstract class  AParca
    {
        private string name;
        public AParca(string name)
        {
            this.name = name;
        }
        public String GetName()
        {
            return name;
        }
    }
}
