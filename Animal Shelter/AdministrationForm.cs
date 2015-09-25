using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            //animal = null;
            administration = new Administration();
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            string selecteditem = animalTypeComboBox.SelectedItem.ToString();
            string chipnr = txtChipNr.Text;
            string name = txtName.Text;

            DateTime dateofbirth = dateBirth.Value;
            SimpleDate simpledateofbirth = new SimpleDate(dateofbirth.Day, dateofbirth.Month, dateofbirth.Year);

            if(selecteditem == "Cat")
            {
                animal = new Cat(chipnr, simpledateofbirth, name, txtBadHabits.Text);
            }
            else if(selecteditem == "Dog")
            {
                SimpleDate simpledatelastwalk = new SimpleDate(dateLastWalk.Value.Day, dateLastWalk.Value.Month, dateLastWalk.Value.Year);
                animal = new Dog(chipnr, simpledateofbirth, name, simpledatelastwalk);
            }
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            // TODO: See method description
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
    }
}
