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
            this.groupBoxTakingCar = new System.Windows.Forms.GroupBox();
            this.buttonTakeCar = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonSetCar = new System.Windows.Forms.Button();
            this.buttonSetSamosval = new System.Windows.Forms.Button();
            this.labelCompare = new System.Windows.Forms.Label();
            this.maskedTextBoxCompare = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.checkBoxLess = new System.Windows.Forms.CheckBox();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.groupBoxPlaces = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTakingCar.SuspendLayout();
            this.groupBoxPlaces.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(726, 579);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxTakingCar
            // 
            this.groupBoxTakingCar.Controls.Add(this.buttonTakeCar);
            this.groupBoxTakingCar.Controls.Add(this.maskedTextBox);
            this.groupBoxTakingCar.Controls.Add(this.labelPlace);
            this.groupBoxTakingCar.Location = new System.Drawing.Point(741, 111);
            this.groupBoxTakingCar.Name = "groupBoxTakingCar";
            this.groupBoxTakingCar.Size = new System.Drawing.Size(110, 93);
            this.groupBoxTakingCar.TabIndex = 3;
            this.groupBoxTakingCar.TabStop = false;
            this.groupBoxTakingCar.Text = "Забрать машину";
            // 
            // buttonTakeCar
            // 
            this.buttonTakeCar.Location = new System.Drawing.Point(10, 64);
            this.buttonTakeCar.Name = "buttonTakeCar";
            this.buttonTakeCar.Size = new System.Drawing.Size(75, 23);
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
            // buttonSetCar
            // 
            this.buttonSetCar.Location = new System.Drawing.Point(741, 12);
            this.buttonSetCar.Name = "buttonSetCar";
            this.buttonSetCar.Size = new System.Drawing.Size(110, 34);
            this.buttonSetCar.TabIndex = 5;
            this.buttonSetCar.Text = "Припарковать грузовик";
            this.buttonSetCar.UseVisualStyleBackColor = true;
            this.buttonSetCar.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // buttonSetSamosval
            // 
            this.buttonSetSamosval.Location = new System.Drawing.Point(741, 52);
            this.buttonSetSamosval.Name = "buttonSetSamosval";
            this.buttonSetSamosval.Size = new System.Drawing.Size(110, 38);
            this.buttonSetSamosval.TabIndex = 6;
            this.buttonSetSamosval.Text = "Припарковать самосвал";
            this.buttonSetSamosval.UseVisualStyleBackColor = true;
            this.buttonSetSamosval.Click += new System.EventHandler(this.buttonSetSamosval_Click);
            // 
            // labelCompare
            // 
            this.labelCompare.Location = new System.Drawing.Point(0, 44);
            this.labelCompare.Name = "labelCompare";
            this.labelCompare.Size = new System.Drawing.Size(125, 20);
            this.labelCompare.TabIndex = 8;
            this.labelCompare.Text = "Число для сравнения:";
            // 
            // maskedTextBoxCompare
            // 
            this.maskedTextBoxCompare.Location = new System.Drawing.Point(30, 67);
            this.maskedTextBoxCompare.Name = "maskedTextBoxCompare";
            this.maskedTextBoxCompare.Size = new System.Drawing.Size(72, 20);
            this.maskedTextBoxCompare.TabIndex = 11;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.Location = new System.Drawing.Point(0, 90);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(67, 17);
            this.checkBoxMore.TabIndex = 12;
            this.checkBoxMore.Text = "Больше";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // checkBoxLess
            // 
            this.checkBoxLess.AutoSize = true;
            this.checkBoxLess.Location = new System.Drawing.Point(59, 90);
            this.checkBoxLess.Name = "checkBoxLess";
            this.checkBoxLess.Size = new System.Drawing.Size(67, 17);
            this.checkBoxLess.TabIndex = 13;
            this.checkBoxLess.Text = "Меньше";
            this.checkBoxLess.UseVisualStyleBackColor = true;
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(13, 113);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(89, 44);
            this.buttonCompare.TabIndex = 14;
            this.buttonCompare.Text = "Сравнить количество заполенных мест";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.ButtonCompare_Click);
            // 
            // groupBoxPlaces
            // 
            this.groupBoxPlaces.Controls.Add(this.labelCompare);
            this.groupBoxPlaces.Controls.Add(this.buttonCompare);
            this.groupBoxPlaces.Controls.Add(this.maskedTextBoxCompare);
            this.groupBoxPlaces.Controls.Add(this.checkBoxLess);
            this.groupBoxPlaces.Controls.Add(this.checkBoxMore);
            this.groupBoxPlaces.Location = new System.Drawing.Point(732, 399);
            this.groupBoxPlaces.Name = "groupBoxPlaces";
            this.groupBoxPlaces.Size = new System.Drawing.Size(126, 168);
            this.groupBoxPlaces.TabIndex = 15;
            this.groupBoxPlaces.TabStop = false;
            this.groupBoxPlaces.Text = "Количество занятых мест";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 579);
            this.Controls.Add(this.groupBoxPlaces);
            this.Controls.Add(this.buttonSetSamosval);
            this.Controls.Add(this.buttonSetCar);
            this.Controls.Add(this.groupBoxTakingCar);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Гараж";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTakingCar.ResumeLayout(false);
            this.groupBoxTakingCar.PerformLayout();
            this.groupBoxPlaces.ResumeLayout(false);
            this.groupBoxPlaces.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxTakingCar;
        private System.Windows.Forms.Button buttonTakeCar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonSetCar;
        private System.Windows.Forms.Button buttonSetSamosval;
        private System.Windows.Forms.Label labelCompare;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCompare;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.CheckBox checkBoxLess;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.GroupBox groupBoxPlaces;
    }
}