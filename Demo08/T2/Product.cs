using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Product
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public override string ToString()
        {
            return "- "+ Name + " , " +Value + "e";
        }       
    }
}
