using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Administration
    {
        List<Animal> animals;
        public Administration()
        {
            animals = new List<Animal>();
        }

        public bool Add(Animal animal)
        {
            return false;
        }

        public bool RemoveAnimal(string chipRegistrationNumber)
        {
            return false;
        }

        public Animal FindAnimal(string chipRegistrationNumber)
        {
            return null;
        }
    }
}
