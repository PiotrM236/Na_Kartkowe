using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazki
{
    public class Class1
    {
       

        public string zmiana { get; set; }
        public int polubienia { get; set; }

        public Class1(string zmiana)
        {
            this.zmiana = zmiana;
            polubienia = 0;
        }

      

        public int polubienie()
        {
             return polubienia++;
        }
    }

}
