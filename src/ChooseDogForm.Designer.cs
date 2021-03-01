﻿namespace DogForLife
{
    partial class ChooseDogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseDogForm));
            this.label_No_Dogs_Available = new System.Windows.Forms.Label();
            this.dataGridView_ListDog = new System.Windows.Forms.DataGridView();
            this.Dog_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dog_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dog_Date_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dog_Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dog_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dog_Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dog_Breed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dog_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dog_Charater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_Ok = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListDog)).BeginInit();
            this.SuspendLayout();
            // 
            // label_No_Dogs_Available
            // 
            this.label_No_Dogs_Available.AutoSize = true;
            this.label_No_Dogs_Available.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_No_Dogs_Available.Location = new System.Drawing.Point(266, 95);
            this.label_No_Dogs_Available.Name = "label_No_Dogs_Available";
            this.label_No_Dogs_Available.Size = new System.Drawing.Size(202, 28);
            this.label_No_Dogs_Available.TabIndex = 22;
            this.label_No_Dogs_Available.Text = "No Dogs Available For Adoption";
            // 
            // dataGridView_ListDog
            // 
            this.dataGridView_ListDog.AllowUserToAddRows = false;
            this.dataGridView_ListDog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView_ListDog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListDog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dog_ID,
            this.Dog_Name,
            this.Dog_Date_of_birth,
            this.Dog_Height,
            this.Dog_Weight,
            this.Dog_Color,
            this.Dog_Breed,
            this.Dog_Gender,
            this.Dog_Charater});
            this.dataGridView_ListDog.Location = new System.Drawing.Point(1, 1);
            this.dataGridView_ListDog.Name = "dataGridView_ListDog";
            this.dataGridView_ListDog.Size = new System.Drawing.Size(746, 307);
            this.dataGridView_ListDog.TabIndex = 21;
            // 
            // Dog_ID
            // 
            this.Dog_ID.HeaderText = "ID";
            this.Dog_ID.Name = "Dog_ID";
            this.Dog_ID.ReadOnly = true;
            this.Dog_ID.Width = 70;
            // 
            // Dog_Name
            // 
            this.Dog_Name.HeaderText = "Name";
            this.Dog_Name.Name = "Dog_Name";
            this.Dog_Name.ReadOnly = true;
            this.Dog_Name.Width = 90;
            // 
            // Dog_Date_of_birth
            // 
            this.Dog_Date_of_birth.HeaderText = "Date birth";
            this.Dog_Date_of_birth.Name = "Dog_Date_of_birth";
            this.Dog_Date_of_birth.ReadOnly = true;
            this.Dog_Date_of_birth.Visible = false;
            this.Dog_Date_of_birth.Width = 90;
            // 
            // Dog_Height
            // 
            this.Dog_Height.HeaderText = "Height";
            this.Dog_Height.Name = "Dog_Height";
            this.Dog_Height.ReadOnly = true;
            this.Dog_Height.Width = 90;
            // 
            // Dog_Weight
            // 
            this.Dog_Weight.HeaderText = "Weight";
            this.Dog_Weight.Name = "Dog_Weight";
            this.Dog_Weight.ReadOnly = true;
            this.Dog_Weight.Width = 90;
            // 
            // Dog_Color
            // 
            this.Dog_Color.HeaderText = "Color";
            this.Dog_Color.Name = "Dog_Color";
            this.Dog_Color.ReadOnly = true;
            this.Dog_Color.Width = 90;
            // 
            // Dog_Breed
            // 
            this.Dog_Breed.HeaderText = "Breed";
            this.Dog_Breed.Name = "Dog_Breed";
            this.Dog_Breed.ReadOnly = true;
            this.Dog_Breed.Width = 90;
            // 
            // Dog_Gender
            // 
            this.Dog_Gender.HeaderText = "Gender";
            this.Dog_Gender.Name = "Dog_Gender";
            this.Dog_Gender.ReadOnly = true;
            this.Dog_Gender.Width = 90;
            // 
            // Dog_Charater
            // 
            this.Dog_Charater.HeaderText = "Charater";
            this.Dog_Charater.Name = "Dog_Charater";
            this.Dog_Charater.ReadOnly = true;
            this.Dog_Charater.Width = 90;
            // 
            // button_Cancel
            // 
            this.button_Cancel.ActiveBorderThickness = 1;
            this.button_Cancel.ActiveCornerRadius = 20;
            this.button_Cancel.ActiveFillColor = System.Drawing.Color.Black;
            this.button_Cancel.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Cancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.button_Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Cancel.BackgroundImage")));
            this.button_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Cancel.ButtonText = "Cancel";
            this.button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_Cancel.IdleBorderThickness = 1;
            this.button_Cancel.IdleCornerRadius = 20;
            this.button_Cancel.IdleFillColor = System.Drawing.Color.Red;
            this.button_Cancel.IdleForecolor = System.Drawing.Color.Black;
            this.button_Cancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_Cancel.Location = new System.Drawing.Point(197, 316);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(5);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(100, 33);
            this.button_Cancel.TabIndex = 24;
            this.button_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.ActiveBorderThickness = 1;
            this.button_Ok.ActiveCornerRadius = 20;
            this.button_Ok.ActiveFillColor = System.Drawing.Color.Black;
            this.button_Ok.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Ok.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Ok.BackColor = System.Drawing.SystemColors.Control;
            this.button_Ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Ok.BackgroundImage")));
            this.button_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Ok.ButtonText = "OK";
            this.button_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Ok.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ok.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_Ok.IdleBorderThickness = 1;
            this.button_Ok.IdleCornerRadius = 20;
            this.button_Ok.IdleFillColor = System.Drawing.Color.Lime;
            this.button_Ok.IdleForecolor = System.Drawing.Color.Black;
            this.button_Ok.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_Ok.Location = new System.Drawing.Point(397, 316);
            this.button_Ok.Margin = new System.Windows.Forms.Padding(5);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(100, 33);
            this.button_Ok.TabIndex = 23;
            this.button_Ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // ChooseDogFoem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 355);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label_No_Dogs_Available);
            this.Controls.Add(this.dataGridView_ListDog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseDogFoem";
            this.Text = "ChooseDogFoem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_No_Dogs_Available;
        private System.Windows.Forms.DataGridView dataGridView_ListDog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Date_of_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Breed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Charater;
        private Bunifu.Framework.UI.BunifuThinButton2 button_Cancel;
        private Bunifu.Framework.UI.BunifuThinButton2 button_Ok;
    }
}