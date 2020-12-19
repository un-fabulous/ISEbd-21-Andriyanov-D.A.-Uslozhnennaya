namespace Samosvalllll
{
	partial class FormCar
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.pictureBoxSamosval = new System.Windows.Forms.PictureBox();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonCreateGruz = new System.Windows.Forms.Button();
            this.comboBoxWheels = new System.Windows.Forms.ComboBox();
            this.checkBoxTriangle = new System.Windows.Forms.CheckBox();
            this.checkBoxRectangle = new System.Windows.Forms.CheckBox();
            this.checkBoxCircle = new System.Windows.Forms.CheckBox();
            this.groupBoxSamosvalParams = new System.Windows.Forms.GroupBox();
            this.labelOrnament = new System.Windows.Forms.Label();
            this.labelWheelsNumber = new System.Windows.Forms.Label();
            this.buttonCreateSamosval = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSamosval)).BeginInit();
            this.groupBoxSamosvalParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxSamosval
            // 
            this.pictureBoxSamosval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSamosval.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSamosval.Name = "pictureBoxSamosval";
            this.pictureBoxSamosval.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxSamosval.TabIndex = 1;
            this.pictureBoxSamosval.TabStop = false;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::Samosvalllll.Properties.Resources.стр_вправо___копия__2_;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(686, 378);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::Samosvalllll.Properties.Resources.стр_вправо___копия;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(722, 351);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 4;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::Samosvalllll.Properties.Resources.стр_вправо___копия__3_;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(722, 408);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::Samosvalllll.Properties.Resources.стр_вправо;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(758, 378);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 6;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateGruz
            // 
            this.buttonCreateGruz.Location = new System.Drawing.Point(665, 22);
            this.buttonCreateGruz.Name = "buttonCreateGruz";
            this.buttonCreateGruz.Size = new System.Drawing.Size(114, 23);
            this.buttonCreateGruz.TabIndex = 7;
            this.buttonCreateGruz.Text = "Создать грузовик";
            this.buttonCreateGruz.UseVisualStyleBackColor = true;
            this.buttonCreateGruz.Click += new System.EventHandler(this.buttonCreateGruz_Click);
            // 
            // comboBoxWheels
            // 
            this.comboBoxWheels.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxWheels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxWheels.FormattingEnabled = true;
            this.comboBoxWheels.Location = new System.Drawing.Point(6, 49);
            this.comboBoxWheels.Name = "comboBoxWheels";
            this.comboBoxWheels.Size = new System.Drawing.Size(116, 21);
            this.comboBoxWheels.TabIndex = 8;
            // 
            // checkBoxTriangle
            // 
            this.checkBoxTriangle.AutoSize = true;
            this.checkBoxTriangle.Location = new System.Drawing.Point(6, 113);
            this.checkBoxTriangle.Name = "checkBoxTriangle";
            this.checkBoxTriangle.Size = new System.Drawing.Size(91, 17);
            this.checkBoxTriangle.TabIndex = 11;
            this.checkBoxTriangle.Text = "Треугольник";
            this.checkBoxTriangle.UseVisualStyleBackColor = true;
            // 
            // checkBoxRectangle
            // 
            this.checkBoxRectangle.AutoSize = true;
            this.checkBoxRectangle.Location = new System.Drawing.Point(6, 136);
            this.checkBoxRectangle.Name = "checkBoxRectangle";
            this.checkBoxRectangle.Size = new System.Drawing.Size(106, 17);
            this.checkBoxRectangle.TabIndex = 12;
            this.checkBoxRectangle.Text = "Прямоугольник";
            this.checkBoxRectangle.UseVisualStyleBackColor = true;
            // 
            // checkBoxCircle
            // 
            this.checkBoxCircle.AutoSize = true;
            this.checkBoxCircle.Location = new System.Drawing.Point(6, 159);
            this.checkBoxCircle.Name = "checkBoxCircle";
            this.checkBoxCircle.Size = new System.Drawing.Size(49, 17);
            this.checkBoxCircle.TabIndex = 13;
            this.checkBoxCircle.Text = "Круг";
            this.checkBoxCircle.UseVisualStyleBackColor = true;
            // 
            // groupBoxSamosvalParams
            // 
            this.groupBoxSamosvalParams.Controls.Add(this.labelOrnament);
            this.groupBoxSamosvalParams.Controls.Add(this.labelWheelsNumber);
            this.groupBoxSamosvalParams.Controls.Add(this.checkBoxTriangle);
            this.groupBoxSamosvalParams.Controls.Add(this.comboBoxWheels);
            this.groupBoxSamosvalParams.Controls.Add(this.checkBoxCircle);
            this.groupBoxSamosvalParams.Controls.Add(this.checkBoxRectangle);
            this.groupBoxSamosvalParams.Controls.Add(this.buttonCreateSamosval);
            this.groupBoxSamosvalParams.Location = new System.Drawing.Point(659, 66);
            this.groupBoxSamosvalParams.Name = "groupBoxSamosvalParams";
            this.groupBoxSamosvalParams.Size = new System.Drawing.Size(129, 215);
            this.groupBoxSamosvalParams.TabIndex = 15;
            this.groupBoxSamosvalParams.TabStop = false;
            this.groupBoxSamosvalParams.Text = "Самосвал";
            // 
            // labelOrnament
            // 
            this.labelOrnament.AutoSize = true;
            this.labelOrnament.Location = new System.Drawing.Point(6, 97);
            this.labelOrnament.Name = "labelOrnament";
            this.labelOrnament.Size = new System.Drawing.Size(117, 13);
            this.labelOrnament.TabIndex = 15;
            this.labelOrnament.Text = "Орнамент на колесах";
            // 
            // labelWheelsNumber
            // 
            this.labelWheelsNumber.AutoSize = true;
            this.labelWheelsNumber.Location = new System.Drawing.Point(7, 30);
            this.labelWheelsNumber.Name = "labelWheelsNumber";
            this.labelWheelsNumber.Size = new System.Drawing.Size(102, 13);
            this.labelWheelsNumber.TabIndex = 14;
            this.labelWheelsNumber.Text = "Количество колес:";
            // 
            // buttonCreateSamosval
            // 
            this.buttonCreateSamosval.Location = new System.Drawing.Point(4, 182);
            this.buttonCreateSamosval.Name = "buttonCreateSamosval";
            this.buttonCreateSamosval.Size = new System.Drawing.Size(116, 23);
            this.buttonCreateSamosval.TabIndex = 2;
            this.buttonCreateSamosval.Text = "Создать самосвал";
            this.buttonCreateSamosval.UseVisualStyleBackColor = true;
            this.buttonCreateSamosval.Click += new System.EventHandler(this.ButtonCreateSamosval_Click);
            // 
            // FormSamosval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxSamosvalParams);
            this.Controls.Add(this.buttonCreateGruz);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.pictureBoxSamosval);
            this.Name = "FormSamosval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Самосвал";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSamosval)).EndInit();
            this.groupBoxSamosvalParams.ResumeLayout(false);
            this.groupBoxSamosvalParams.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxSamosval;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonCreateGruz;
        private System.Windows.Forms.ComboBox comboBoxWheels;
        private System.Windows.Forms.CheckBox checkBoxTriangle;
        private System.Windows.Forms.CheckBox checkBoxRectangle;
        private System.Windows.Forms.CheckBox checkBoxCircle;
        private System.Windows.Forms.GroupBox groupBoxSamosvalParams;
        private System.Windows.Forms.Label labelOrnament;
        private System.Windows.Forms.Label labelWheelsNumber;
        private System.Windows.Forms.Button buttonCreateSamosval;
    }
}