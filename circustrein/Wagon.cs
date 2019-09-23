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

        public void WagonMaker(Animal animal)
        {
            Wagon wagon = new Wagon();
            AddAnimal(wagon, animal);
        }

        private void AddAnimal(Wagon wagon, Animal animal)
        {
            wagon.Animalsinwagon.Add(animal);
            wagon.Capacity += animal.Weight;
        }

        public void AnimalsChecker (List<Animal> AnimalsChecker, Animal animal)
        {
            foreach (Animal wagonAnimal in AnimalsChecker)
            {
                if (wagonAnimal.Eater == Eater.carnivoor)
                {
                    if (SizeChecker(wagonAnimal, animal))
                    {
                    
                    }
                }
            }
        }
       
        public bool SizeChecker(Animal wagonanimal, Animal animal)
        {
            if (wagonanimal.Weight <= animal.Weight) return true;
            return false;
        }
       

        public bool CapacityCheck(Wagon wagon, Animal animal)
        {
            if (wagon.Capacity + animal.Weight <= 10) return true;
            return false;
            
        }
        
    }
}
