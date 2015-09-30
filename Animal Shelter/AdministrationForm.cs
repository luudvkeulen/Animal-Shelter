using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        //private Animal animal;
        private Administration administration;

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            administration = new Administration();
        }

        private void TestData()
        {
            Random r = new Random();
            //Not reserved
            /*administration.Add(new Dog(r.Next(100, 1000000).ToString(), GenerateSimpleDate(), "Bart", GenerateSimpleDate()));
            administration.Add(new Dog(r.Next(100, 1000000).ToString(), GenerateSimpleDate(), "Jan", GenerateSimpleDate()));
            administration.Add(new Dog(r.Next(100, 1000000).ToString(), GenerateSimpleDate(), "Jaap", GenerateSimpleDate()));
            administration.Add(new Dog(r.Next(100, 1000000).ToString(), GenerateSimpleDate(), "Roos", GenerateSimpleDate()));
            administration.Add(new Cat(r.Next(100, 1000000).ToString(), GenerateSimpleDate(), "Lola", "Test"));
            administration.Add(new Cat(r.Next(100, 1000000).ToString(), GenerateSimpleDate(), "Kim", "Test"));
            administration.Add(new Cat(r.Next(100, 1000000).ToString(), GenerateSimpleDate(), "Geert", "Test"));
            administration.Add(new Cat(r.Next(100, 1000000).ToString(), GenerateSimpleDate(), "Vincent", "Test"));

            //Reserved
            Dog dog = new Dog(r.Next(100, 1000000).ToString(), GenerateSimpleDate(), "Pieter", GenerateSimpleDate());
            Cat cat = new Cat(r.Next(100, 1000000).ToString(), GenerateSimpleDate(), "Karel", "Test");
            dog.IsReserved = cat.IsReserved = true;
            administration.Add(dog);
            administration.Add(cat);*/
        }

        private SimpleDate GenerateSimpleDate()
        {
            Random r = new Random();
            return new SimpleDate(r.Next(1, 31), r.Next(1, 12), r.Next(1900, 2016));
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            string selecteditem = animalTypeComboBox.SelectedItem.ToString();
            string chipnr = numChipNr.ToString();
            if(chipnr == "")
            {
                MessageBox.Show("Voer een chipnummer in!");
                return;
            }
            string name = txtName.Text;

            DateTime dateofbirth = dateBirth.Value;
            SimpleDate simpledateofbirth = new SimpleDate(dateofbirth.Day, dateofbirth.Month, dateofbirth.Year);

            if(selecteditem == "Cat")
            {
                int badhabitslength = txtBadHabits.Text.Length;

                if (administration.Add(new Cat(chipnr, simpledateofbirth, name, txtBadHabits.Text, badhabitslength)))
                {
                    FillLists();
                }
                else
                {
                    MessageBox.Show("Er bestaat al een dier met dit chipnummer");
                }
            }
            else if(selecteditem == "Dog")
            {
                SimpleDate simpledatelastwalk = new SimpleDate(dateLastWalk.Value.Day, dateLastWalk.Value.Month, dateLastWalk.Value.Year);
                
                if(administration.Add(new Dog(chipnr, simpledateofbirth, name, simpledatelastwalk)))
                {
                    FillLists();
                }
                else
                {
                    MessageBox.Show("Er bestaat al een dier met dit chipnummer");
                }
            }
        }

        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeSelected(animalTypeComboBox.SelectedItem.ToString());
        }

        private void TypeSelected(string animaltype)
        {
            if(animaltype == "Dog")
            {
                lblLastWalk.Enabled = dateLastWalk.Enabled = lblLastWalk.Visible = dateLastWalk.Visible = true;
                lblBadHabits.Enabled = txtBadHabits.Enabled = lblBadHabits.Visible = txtBadHabits.Visible = false;
            }
            else if(animaltype == "Cat")
            {
                lblLastWalk.Enabled = dateLastWalk.Enabled = lblLastWalk.Visible = dateLastWalk.Visible = false;
                lblBadHabits.Enabled = txtBadHabits.Enabled = lblBadHabits.Visible = txtBadHabits.Visible = true;
            }
        }

        private void FillLists()
        {
            List<Animal> animals = administration.animals;
            List<Animal> reservedanimals = animals.FindAll(a => a.IsReserved == true);
            List<Animal> freeanimals = animals.FindAll(a => a.IsReserved == false);
            listReserved.DataSource = listNotReserved.DataSource = null; //Set Datasource null otherwise it doesnt refresh the data
            listReserved.DataSource = reservedanimals;
            listNotReserved.DataSource = freeanimals;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Animal animal = (Animal)listNotReserved.SelectedItem;
            if (animal != null && administration.RemoveAnimal(animal.ChipRegistrationNumber))
            {
                FillLists();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal animal = (Animal)listReserved.SelectedItem;
            if (animal != null && administration.RemoveAnimal(animal.ChipRegistrationNumber))
            {
                FillLists();
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            Animal animal = (Animal)listNotReserved.SelectedItem;
            if (animal != null)
            {
                animal.IsReserved = true;
                FillLists();
            }
        }

        private void btnStopReservation_Click(object sender, EventArgs e)
        {
            Animal animal = (Animal)listReserved.SelectedItem;
            if (animal != null)
            {
                animal.IsReserved = false;
                FillLists();
            }
        }

        private void AdministrationForm_Shown(object sender, EventArgs e)
        {
            TestData();
            FillLists();
        }
    }
}
