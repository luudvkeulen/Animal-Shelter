using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Oracle.ManagedDataAccess.Client;

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

        public void SaveAnimals(bool local)
        {
            if (local)
            {
                using (FileStream FS = new FileStream("objects.bin", FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter BF = new BinaryFormatter();
                    BF.Serialize(FS, animals);
                }
            }
            else
            {
                
            }
        }

        public void ReadAnimals(bool local)
        {
            if (local)
            {
                try
                {
                    using (FileStream FS = new FileStream("objects.bin", FileMode.Open, FileAccess.Read))
                    {
                        BinaryFormatter BF = new BinaryFormatter();
                        animals = (List<Animal>)BF.Deserialize(FS);
                    }
                }
                catch (FileNotFoundException FNFE)
                {
                    Console.WriteLine(FNFE.Message);
                }
            }
            else
            {
                using (OracleConnection connection = Database.Connection)
                {
                    string sqlquery = "SELECT CHIPREGISTRATIONNUMBER, DATEOFBIRTH, NAME, RESERVED, PRICE, LASTWALKDATE, BADHABITS FROM ANIMALS";
                    OracleCommand OC = new OracleCommand(sqlquery, connection);
                    OracleDataReader ODR = OC.ExecuteReader();

                    string ChipRegistrationNumber = "";
                    string Name = "";
                    string BadHabits = "";
                    SimpleDate DateOfBirth = null;
                    SimpleDate LastWalkDate = null;
                    bool Reserved = false;
                    decimal Price = 0;

                    //List<Animal> animal = new List<Animal>();

                    while (ODR.Read())
                    {
                        ChipRegistrationNumber = ODR["CHIPREGISTRATIONNUMBER"].ToString();
                        Name = ODR["NAME"].ToString();
                        BadHabits = ODR["BADHABITS"].ToString();

                        DateTime DT = DateTime.Parse(ODR["DATEOFBIRTH"].ToString());
                        DateOfBirth = new SimpleDate(DT.Day, DT.Month, DT.Year);

                        DT = DateTime.Parse(ODR["LASTWALKDATE"].ToString());
                        LastWalkDate = new SimpleDate(DT.Day, DT.Month, DT.Year);

                        Reserved = Convert.ToBoolean(ODR["RESERVED"]);
                        Price = Convert.ToDecimal(ODR["PRICE"]);

                        if (BadHabits != "")
                        {
                            animals.Add(new Cat(ChipRegistrationNumber, DateOfBirth, Name, BadHabits));
                        }
                        else
                        {
                            animals.Add(new Dog(ChipRegistrationNumber, DateOfBirth, Name, LastWalkDate));
                        }
                    }
                }
            }
        }
    }
}
