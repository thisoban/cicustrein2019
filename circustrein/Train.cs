using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
   public class Train
    {
        List<Wagon> Wagons;
        List<Animal> animalsperron = new List<Animal>();
        public Train()
        {
            Wagons = new List<Wagon>();
        }

        public void WagonAvailable(Wagon wagon )
        {
            foreach(Wagon Wagon  in  Wagons)
            {
                
            }
        }

        private void wagonAdd()
        {
            throw new NotImplementedException();
        }
    }
}
