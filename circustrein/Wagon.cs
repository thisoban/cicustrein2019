using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
   public class Wagon 
    {
        public int Capacity { get; set; }

        List<Animal> Animalsinwagon;
        public Wagon()
        {
            Capacity = 0;
            Animalsinwagon = new List<Animal>();
        }

        public void WagonMaker(Animal ianimal)
        {
            Wagon wagon = new Wagon();
            AddAnimal(wagon, ianimal);
        }

        private void AddAnimal(Wagon wagon, Animal newAnimal)
        {
            wagon.Animalsinwagon.Add(newAnimal);
            wagon.Capacity += newAnimal.Weight;
        }

        public void AnimalsChecker (List<Animal> AnimalsChecker, Animal newanimal)
        {
            foreach (Animal wagonAnimal in AnimalsChecker)
            {
                if (wagonAnimal.Eater == Eater.carnivoor)
                {
                    if (SizeChecker(wagonAnimal, newanimal))
                    {
                    
                    }
                }
            }
        }
       
        public bool SizeChecker(Animal wagonanimal, Animal newanimal)
        {
            if (wagonanimal.Weight <= newanimal.Weight) return true;
            return false;
        }
       

        public bool CapacityCheck(Wagon wagon, Animal ianimal)
        {
            if (wagon.Capacity + ianimal.Weight <= 10) return true;
            return false;
            
        }
        
    }
}
