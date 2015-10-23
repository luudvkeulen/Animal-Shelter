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
                using(OracleConnection connection = Database.Connection)
                {
                    List<string> inserts = new List<string>();
                    inserts.Add("TRUNCATE TABLE ANIMALS");
                    foreach (Animal animal in animals)
                    {
                        string sqlquery;
                        string ChipRegistrationNumber = animal.ChipRegistrationNumber;
                        string DateOfBirth = string.Format("{0}, {1}, {2}", animal.DateOfBirth.Day, animal.DateOfBirth.Month,animal.DateOfBirth.Year);
                        int reserved = Convert.ToInt32(animal.IsReserved);
                        string Name = animal.Name;
                        if (animal is Cat)
                        {
                            Cat cat = (Cat)animal;
                            sqlquery = string.Format("INSERT INTO ANIMALS (CHIPREGISTRATIONNUMBER, DATEOFBIRTH, NAME, RESERVED, PRICE, BADHABITS) VALUES ('{0}', TO_DATE('{1}', 'DD-MM-YYYY'), '{2}', '{3}', '{4}', '{5}')", ChipRegistrationNumber, DateOfBirth, Name, reserved, cat.Price, cat.BadHabits);
                        }
                        else
                        {
                            Dog dog = (Dog)animal;
                            string LastWalkDate = string.Format("{0}, {1}, {2}", dog.LastWalkDate.Day, dog.LastWalkDate.Month, dog.LastWalkDate.Year);
                            sqlquery = string.Format("INSERT INTO ANIMALS (CHIPREGISTRATIONNUMBER, DATEOFBIRTH, NAME, RESERVED, PRICE, LASTWALKDATE) VALUES ('{0}', TO_DATE('{1}', 'DD-MM-YYYY'), '{2}', '{3}', '{4}', TO_DATE('{5}', 'DD-MM-YYYY'))", ChipRegistrationNumber, DateOfBirth, Name, reserved, dog.Price, LastWalkDate);
                        }

                        inserts.Add(sqlquery);
                    }

                    OracleCommand OC;
                    foreach(string insert in inserts)
                    {
                        OC = new OracleCommand(insert, connection);
                        try
                        {
                            OC.ExecuteNonQuery();
                        }
                        catch { }
                    }
                }
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
                        if (ODR["LASTWALKDATE"].ToString() != "")
                        {
                            DT = DateTime.Parse(ODR["LASTWALKDATE"].ToString());
                        }
                        LastWalkDate = new SimpleDate(DT.Day, DT.Month, DT.Year);

                        Reserved = Convert.ToBoolean(ODR["RESERVED"]);
                        Price = Convert.ToDecimal(ODR["PRICE"]);

                        if (BadHabits != "")
                        {
                            Cat cat = new Cat(ChipRegistrationNumber, DateOfBirth, Name, BadHabits);
                            cat.IsReserved = Reserved;
                            animals.Add(cat);

                        }
                        else
                        {
                            Dog dog = new Dog(ChipRegistrationNumber, DateOfBirth, Name, LastWalkDate);
                            dog.IsReserved = Reserved;
                            animals.Add(dog);
                        }
                    }
                }
            }
        }
    }
}
