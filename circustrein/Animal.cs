using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Animal 
    {
        public int Weight { get;}
       public Eater Eater { get;}

        public Animal(int weight, Eater soort)
        {
            Weight = weight;
            Eater = soort;
        }

      
    }
}
