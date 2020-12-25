namespace Samosvalllll
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxTakeCar = new System.Windows.Forms.GroupBox();
            this.buttonUnparkingCars = new System.Windows.Forms.Button();
            this.buttonTakeCar = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.labelParking = new System.Windows.Forms.Label();
            this.buttonParking = new System.Windows.Forms.Button();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.buttonDeleteParking = new System.Windows.Forms.Button();
            this.buttonSetCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTakeCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(726, 463);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxTakeCar
            // 
            this.groupBoxTakeCar.Controls.Add(this.buttonUnparkingCars);
            this.groupBoxTakeCar.Controls.Add(this.buttonTakeCar);
            this.groupBoxTakeCar.Controls.Add(this.maskedTextBox);
            this.groupBoxTakeCar.Controls.Add(this.labelPlace);
            this.groupBoxTakeCar.Location = new System.Drawing.Point(740, 300);
            this.groupBoxTakeCar.Name = "groupBoxTakeCar";
            this.groupBoxTakeCar.Size = new System.Drawing.Size(110, 125);
            this.groupBoxTakeCar.TabIndex = 3;
            this.groupBoxTakeCar.TabStop = false;
            this.groupBoxTakeCar.Text = "Забрать машину";
            // 
            // buttonUnparkingCars
            // 
            this.buttonUnparkingCars.Location = new System.Drawing.Point(11, 93);
            this.buttonUnparkingCars.Name = "buttonUnparkingCars";
            this.buttonUnparkingCars.Size = new System.Drawing.Size(93, 23);
            this.buttonUnparkingCars.TabIndex = 12;
            this.buttonUnparkingCars.Text = "Просмотреть";
            this.buttonUnparkingCars.UseVisualStyleBackColor = true;
            this.buttonUnparkingCars.Click += new System.EventHandler(this.ButtonUnparkingCars_Click);
            // 
            // buttonTakeCar
            // 
            this.buttonTakeCar.Location = new System.Drawing.Point(10, 64);
            this.buttonTakeCar.Name = "buttonTakeCar";
            this.buttonTakeCar.Size = new System.Drawing.Size(94, 23);
            this.buttonTakeCar.TabIndex = 4;
            this.buttonTakeCar.Text = "Забрать";
            this.buttonTakeCar.UseVisualStyleBackColor = true;
            this.buttonTakeCar.Click += new System.EventHandler(this.buttonTakeCar_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(56, 38);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(25, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(7, 38);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(740, 34);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(110, 20);
            this.textBoxNewLevelName.TabIndex = 7;
            // 
            // labelParking
            // 
            this.labelParking.AutoSize = true;
            this.labelParking.Location = new System.Drawing.Point(761, 18);
            this.labelParking.Name = "labelParking";
            this.labelParking.Size = new System.Drawing.Size(60, 13);
            this.labelParking.TabIndex = 8;
            this.labelParking.Text = "Парковки:";
            // 
            // buttonParking
            // 
            this.buttonParking.Location = new System.Drawing.Point(740, 60);
            this.buttonParking.Name = "buttonParking";
            this.buttonParking.Size = new System.Drawing.Size(119, 20);
            this.buttonParking.TabIndex = 9;
            this.buttonParking.Text = "Добавить парковку";
            this.buttonParking.UseVisualStyleBackColor = true;
            this.buttonParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(740, 86);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(110, 95);
            this.listBoxParkings.TabIndex = 10;
            this.listBoxParkings.Click += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // buttonDeleteParking
            // 
            this.buttonDeleteParking.Location = new System.Drawing.Point(740, 187);
            this.buttonDeleteParking.Name = "buttonDeleteParking";
            this.buttonDeleteParking.Size = new System.Drawing.Size(119, 23);
            this.buttonDeleteParking.TabIndex = 11;
            this.buttonDeleteParking.Text = "Удалить парковку";
            this.buttonDeleteParking.UseVisualStyleBackColor = true;
            this.buttonDeleteParking.Click += new System.EventHandler(this.buttonDeleteParking_Click);
            // 
            // buttonSetCar
            // 
            this.buttonSetCar.Location = new System.Drawing.Point(740, 216);
            this.buttonSetCar.Name = "buttonSetCar";
            this.buttonSetCar.Size = new System.Drawing.Size(110, 78);
            this.buttonSetCar.TabIndex = 12;
            this.buttonSetCar.Text = "Припарковать автомобиль";
            this.buttonSetCar.UseVisualStyleBackColor = true;
            this.buttonSetCar.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 463);
            this.Controls.Add(this.buttonSetCar);
            this.Controls.Add(this.buttonDeleteParking);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.buttonParking);
            this.Controls.Add(this.labelParking);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.groupBoxTakeCar);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Гараж";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTakeCar.ResumeLayout(false);
            this.groupBoxTakeCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxTakeCar;
        private System.Windows.Forms.Button buttonTakeCar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonUnparkingCars;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label labelParking;
        private System.Windows.Forms.Button buttonParking;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Button buttonDeleteParking;
        private System.Windows.Forms.Button buttonSetCar;
    }
}