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
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateLastWalk = new System.Windows.Forms.DateTimePicker();
            this.lblLastWalk = new System.Windows.Forms.Label();
            this.txtBadHabits = new System.Windows.Forms.TextBox();
            this.lblBadHabits = new System.Windows.Forms.Label();
            this.listReserved = new System.Windows.Forms.ListBox();
            this.listNotReserved = new System.Windows.Forms.ListBox();
            this.lblReserved = new System.Windows.Forms.Label();
            this.lblNotReserved = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnStopReservation = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numChipNr = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numChipNr)).BeginInit();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(167, 175);
            this.animalTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(154, 24);
            this.animalTypeComboBox.TabIndex = 0;
            this.animalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.animalTypeComboBox_SelectedIndexChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(329, 175);
            this.createAnimalButton.Margin = new System.Windows.Forms.Padding(4);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(85, 28);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // dateBirth
            // 
            this.dateBirth.CustomFormat = "dd-MM-yyyy";
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirth.Location = new System.Drawing.Point(167, 53);
            this.dateBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateBirth.ShowUpDown = true;
            this.dateBirth.Size = new System.Drawing.Size(247, 22);
            this.dateBirth.TabIndex = 4;
            this.dateBirth.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(167, 21);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 22);
            this.txtName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "GeboorteDatum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Registratienummer:";
            // 
            // dateLastWalk
            // 
            this.dateLastWalk.CustomFormat = "dd-MM-yyyy";
            this.dateLastWalk.Enabled = false;
            this.dateLastWalk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLastWalk.Location = new System.Drawing.Point(167, 117);
            this.dateLastWalk.Margin = new System.Windows.Forms.Padding(4);
            this.dateLastWalk.Name = "dateLastWalk";
            this.dateLastWalk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateLastWalk.ShowUpDown = true;
            this.dateLastWalk.Size = new System.Drawing.Size(247, 22);
            this.dateLastWalk.TabIndex = 9;
            this.dateLastWalk.Value = new System.DateTime(2015, 9, 21, 0, 0, 0, 0);
            this.dateLastWalk.Visible = false;
            // 
            // lblLastWalk
            // 
            this.lblLastWalk.AutoSize = true;
            this.lblLastWalk.Enabled = false;
            this.lblLastWalk.Location = new System.Drawing.Point(27, 124);
            this.lblLastWalk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastWalk.Name = "lblLastWalk";
            this.lblLastWalk.Size = new System.Drawing.Size(136, 17);
            this.lblLastWalk.TabIndex = 10;
            this.lblLastWalk.Text = "Laatse uitlaatdatum:";
            this.lblLastWalk.Visible = false;
            // 
            // txtBadHabits
            // 
            this.txtBadHabits.Enabled = false;
            this.txtBadHabits.Location = new System.Drawing.Point(167, 117);
            this.txtBadHabits.Margin = new System.Windows.Forms.Padding(4);
            this.txtBadHabits.Multiline = true;
            this.txtBadHabits.Name = "txtBadHabits";
            this.txtBadHabits.Size = new System.Drawing.Size(247, 50);
            this.txtBadHabits.TabIndex = 11;
            this.txtBadHabits.Visible = false;
            // 
            // lblBadHabits
            // 
            this.lblBadHabits.AutoSize = true;
            this.lblBadHabits.Enabled = false;
            this.lblBadHabits.Location = new System.Drawing.Point(24, 124);
            this.lblBadHabits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBadHabits.Name = "lblBadHabits";
            this.lblBadHabits.Size = new System.Drawing.Size(131, 17);
            this.lblBadHabits.TabIndex = 12;
            this.lblBadHabits.Text = "Slechte gewoontes:";
            this.lblBadHabits.Visible = false;
            // 
            // listReserved
            // 
            this.listReserved.FormattingEnabled = true;
            this.listReserved.ItemHeight = 16;
            this.listReserved.Location = new System.Drawing.Point(714, 39);
            this.listReserved.Name = "listReserved";
            this.listReserved.Size = new System.Drawing.Size(287, 164);
            this.listReserved.TabIndex = 13;
            // 
            // listNotReserved
            // 
            this.listNotReserved.FormattingEnabled = true;
            this.listNotReserved.ItemHeight = 16;
            this.listNotReserved.Location = new System.Drawing.Point(421, 39);
            this.listNotReserved.Name = "listNotReserved";
            this.listNotReserved.Size = new System.Drawing.Size(287, 164);
            this.listNotReserved.TabIndex = 14;
            // 
            // lblReserved
            // 
            this.lblReserved.AutoSize = true;
            this.lblReserved.Location = new System.Drawing.Point(711, 21);
            this.lblReserved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReserved.Name = "lblReserved";
            this.lblReserved.Size = new System.Drawing.Size(100, 17);
            this.lblReserved.TabIndex = 15;
            this.lblReserved.Text = "Gereserveerd:";
            // 
            // lblNotReserved
            // 
            this.lblNotReserved.AutoSize = true;
            this.lblNotReserved.Location = new System.Drawing.Point(418, 21);
            this.lblNotReserved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotReserved.Name = "lblNotReserved";
            this.lblNotReserved.Size = new System.Drawing.Size(126, 17);
            this.lblNotReserved.TabIndex = 16;
            this.lblNotReserved.Text = "Niet gereserveerd:";
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(421, 210);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(4);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(139, 27);
            this.btnReserve.TabIndex = 17;
            this.btnReserve.Text = "Reserveer";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnStopReservation
            // 
            this.btnStopReservation.Location = new System.Drawing.Point(716, 210);
            this.btnStopReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopReservation.Name = "btnStopReservation";
            this.btnStopReservation.Size = new System.Drawing.Size(140, 27);
            this.btnStopReservation.TabIndex = 18;
            this.btnStopReservation.Text = "Vrijgeven";
            this.btnStopReservation.UseVisualStyleBackColor = true;
            this.btnStopReservation.Click += new System.EventHandler(this.btnStopReservation_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(568, 210);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 27);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Verwijderen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(864, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "Verwijderen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numChipNr
            // 
            this.numChipNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numChipNr.Location = new System.Drawing.Point(171, 87);
            this.numChipNr.Maximum = new decimal(new int[] {
            9000000,
            0,
            0,
            0});
            this.numChipNr.Name = "numChipNr";
            this.numChipNr.Size = new System.Drawing.Size(243, 22);
            this.numChipNr.TabIndex = 21;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 275);
            this.Controls.Add(this.numChipNr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnStopReservation);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.lblNotReserved);
            this.Controls.Add(this.lblReserved);
            this.Controls.Add(this.listNotReserved);
            this.Controls.Add(this.listReserved);
            this.Controls.Add(this.lblBadHabits);
            this.Controls.Add(this.txtBadHabits);
            this.Controls.Add(this.lblLastWalk);
            this.Controls.Add(this.dateLastWalk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministrationForm";
            this.Text = "Animal Shelter Administration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministrationForm_FormClosing);
            this.Shown += new System.EventHandler(this.AdministrationForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numChipNr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateLastWalk;
        private System.Windows.Forms.Label lblLastWalk;
        private System.Windows.Forms.TextBox txtBadHabits;
        private System.Windows.Forms.Label lblBadHabits;
        private System.Windows.Forms.ListBox listReserved;
        private System.Windows.Forms.ListBox listNotReserved;
        private System.Windows.Forms.Label lblReserved;
        private System.Windows.Forms.Label lblNotReserved;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnStopReservation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numChipNr;
    }
}

