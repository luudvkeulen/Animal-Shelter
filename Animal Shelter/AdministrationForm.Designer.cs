namespace AnimalShelter
{
    partial class AdministrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.txtChipNr = new System.Windows.Forms.TextBox();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateLastWalk = new System.Windows.Forms.DateTimePicker();
            this.lblLastWalk = new System.Windows.Forms.Label();
            this.txtBadHabits = new System.Windows.Forms.TextBox();
            this.lblBadHabits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(21, 144);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(137, 21);
            this.animalTypeComboBox.TabIndex = 0;
            this.animalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.animalTypeComboBox_SelectedIndexChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(166, 142);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(64, 23);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(236, 142);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(75, 23);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // txtChipNr
            // 
            this.txtChipNr.Location = new System.Drawing.Point(125, 69);
            this.txtChipNr.Name = "txtChipNr";
            this.txtChipNr.Size = new System.Drawing.Size(186, 20);
            this.txtChipNr.TabIndex = 3;
            // 
            // dateBirth
            // 
            this.dateBirth.CustomFormat = "dd-MM-yyyy";
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirth.Location = new System.Drawing.Point(125, 43);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateBirth.ShowUpDown = true;
            this.dateBirth.Size = new System.Drawing.Size(186, 20);
            this.dateBirth.TabIndex = 4;
            this.dateBirth.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 20);
            this.txtName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "GeboorteDatum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Registratienummer:";
            // 
            // dateLastWalk
            // 
            this.dateLastWalk.CustomFormat = "dd-MM-yyyy";
            this.dateLastWalk.Enabled = false;
            this.dateLastWalk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLastWalk.Location = new System.Drawing.Point(125, 95);
            this.dateLastWalk.Name = "dateLastWalk";
            this.dateLastWalk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateLastWalk.ShowUpDown = true;
            this.dateLastWalk.Size = new System.Drawing.Size(186, 20);
            this.dateLastWalk.TabIndex = 9;
            this.dateLastWalk.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateLastWalk.Visible = false;
            // 
            // lblLastWalk
            // 
            this.lblLastWalk.AutoSize = true;
            this.lblLastWalk.Enabled = false;
            this.lblLastWalk.Location = new System.Drawing.Point(20, 101);
            this.lblLastWalk.Name = "lblLastWalk";
            this.lblLastWalk.Size = new System.Drawing.Size(102, 13);
            this.lblLastWalk.TabIndex = 10;
            this.lblLastWalk.Text = "Laatse uitlaatdatum:";
            this.lblLastWalk.Visible = false;
            // 
            // txtBadHabits
            // 
            this.txtBadHabits.Enabled = false;
            this.txtBadHabits.Location = new System.Drawing.Point(125, 95);
            this.txtBadHabits.Multiline = true;
            this.txtBadHabits.Name = "txtBadHabits";
            this.txtBadHabits.Size = new System.Drawing.Size(186, 41);
            this.txtBadHabits.TabIndex = 11;
            this.txtBadHabits.Visible = false;
            // 
            // lblBadHabits
            // 
            this.lblBadHabits.AutoSize = true;
            this.lblBadHabits.Enabled = false;
            this.lblBadHabits.Location = new System.Drawing.Point(18, 101);
            this.lblBadHabits.Name = "lblBadHabits";
            this.lblBadHabits.Size = new System.Drawing.Size(101, 13);
            this.lblBadHabits.TabIndex = 12;
            this.lblBadHabits.Text = "Slechte gewoontes:";
            this.lblBadHabits.Visible = false;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 229);
            this.Controls.Add(this.lblBadHabits);
            this.Controls.Add(this.txtBadHabits);
            this.Controls.Add(this.lblLastWalk);
            this.Controls.Add(this.dateLastWalk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.txtChipNr);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.Name = "AdministrationForm";
            this.Text = "Animal Shelter Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.TextBox txtChipNr;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateLastWalk;
        private System.Windows.Forms.Label lblLastWalk;
        private System.Windows.Forms.TextBox txtBadHabits;
        private System.Windows.Forms.Label lblBadHabits;
    }
}

