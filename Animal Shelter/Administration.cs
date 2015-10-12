using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;

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

        public void SaveAnimals()
        {
            using (FileStream FS = new FileStream("objects.xml", FileMode.Create, FileAccess.Write))
            {
                DataContractSerializer DCSCat = new DataContractSerializer(typeof(Cat));
                foreach(Animal animal in animals)
                {
                    if(animal is Cat)
                    {
                        Cat cat = (Cat)animal;
                        DCSCat.WriteObject(FS, cat);
                    }
                    //DCS.WriteObject(FS, animal);
                }
            }
        }
    }
}
