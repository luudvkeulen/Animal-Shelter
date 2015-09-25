using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Administration
    {
        public List<Animal> animals;
        public Administration()
        {
            animals = new List<Animal>();
        }

        public bool Add(Animal animal)
        {
            if(animals.Exists(a => a.ChipRegistrationNumber == animal.ChipRegistrationNumber))
            {
                return false;
            }
            animals.Add(animal);
            return true;
        }

        public bool RemoveAnimal(string chipRegistrationNumber)
        {
            bool AnimalRemoved = false;
            Animal animal = animals.Find(a => a.ChipRegistrationNumber == chipRegistrationNumber);
            if(animal != null)
            {
                animals.Remove(animal);
                AnimalRemoved = true;
            }
            return AnimalRemoved;
        }

        public Animal FindAnimal(string chipRegistrationNumber)
        {
            return animals.Find(a => a.ChipRegistrationNumber == chipRegistrationNumber);
        }
    }
}
