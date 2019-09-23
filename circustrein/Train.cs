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

        public Train(List<Animal> perronanimals)
        {
            Wagons = new List<Wagon>();
            SortingList(perronanimals);
        }

        public void WagonAvailable(Animal tryanimal)
        {
            foreach (Wagon Wagon in Wagons)
            {
                if (Wagon.Capacity <= 10 )
                {
                    
                }
            }
          
        }
     
      
        public List<Animal> SortingList(List<Animal> perronanimals)
        {
            return perronanimals.OrderBy(a => a.Eater).ThenBy( a=> a.Weight).ToList();
        }
    }
}
