namespace DogForLife
{
    partial class DogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Adoption = new System.Windows.Forms.Label();
            this.button_Adoption = new Bunifu.Framework.UI.BunifuImageButton();
            this.label_Add = new System.Windows.Forms.Label();
            this.label_Update = new System.Windows.Forms.Label();
            this.label_Delete = new System.Windows.Forms.Label();
            this.button_Delete = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_Update = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_Add = new Bunifu.Framework.UI.BunifuImageButton();
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
            this.button_Refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_Adoption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListDog)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button_Refresh);
            this.panel1.Controls.Add(this.label_Adoption);
            this.panel1.Controls.Add(this.button_Adoption);
            this.panel1.Controls.Add(this.label_Add);
            this.panel1.Controls.Add(this.label_Update);
            this.panel1.Controls.Add(this.label_Delete);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.dataGridView_ListDog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 304);
            this.panel1.TabIndex = 3;
            // 
            // label_Adoption
            // 
            this.label_Adoption.AutoSize = true;
            this.label_Adoption.BackColor = System.Drawing.Color.SeaGreen;
            this.label_Adoption.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Adoption.Location = new System.Drawing.Point(322, 277);
            this.label_Adoption.Name = "label_Adoption";
            this.label_Adoption.Size = new System.Drawing.Size(76, 21);
            this.label_Adoption.TabIndex = 17;
            this.label_Adoption.Text = "Adoption";
            // 
            // button_Adoption
            // 
            this.button_Adoption.BackColor = System.Drawing.Color.SeaGreen;
            this.button_Adoption.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Adoption.BackgroundImage")));
            this.button_Adoption.Image = ((System.Drawing.Image)(resources.GetObject("button_Adoption.Image")));
            this.button_Adoption.ImageActive = null;
            this.button_Adoption.Location = new System.Drawing.Point(326, 221);
            this.button_Adoption.Name = "button_Adoption";
            this.button_Adoption.Size = new System.Drawing.Size(71, 56);
            this.button_Adoption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Adoption.TabIndex = 16;
            this.button_Adoption.TabStop = false;
            this.button_Adoption.Zoom = 10;
            this.button_Adoption.Click += new System.EventHandler(this.button_Adoption_Click);
            // 
            // label_Add
            // 
            this.label_Add.AutoSize = true;
            this.label_Add.BackColor = System.Drawing.Color.SeaGreen;
            this.label_Add.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Add.Location = new System.Drawing.Point(339, 277);
            this.label_Add.Name = "label_Add";
            this.label_Add.Size = new System.Drawing.Size(39, 21);
            this.label_Add.TabIndex = 15;
            this.label_Add.Text = "Add";
            // 
            // label_Update
            // 
            this.label_Update.AutoSize = true;
            this.label_Update.BackColor = System.Drawing.Color.Gold;
            this.label_Update.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Update.Location = new System.Drawing.Point(441, 277);
            this.label_Update.Name = "label_Update";
            this.label_Update.Size = new System.Drawing.Size(63, 21);
            this.label_Update.TabIndex = 14;
            this.label_Update.Text = "Update";
            // 
            // label_Delete
            // 
            this.label_Delete.AutoSize = true;
            this.label_Delete.BackColor = System.Drawing.Color.Red;
            this.label_Delete.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Delete.Location = new System.Drawing.Point(558, 277);
            this.label_Delete.Name = "label_Delete";
            this.label_Delete.Size = new System.Drawing.Size(57, 21);
            this.label_Delete.TabIndex = 13;
            this.label_Delete.Text = "Delete";
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Red;
            this.button_Delete.Image = ((System.Drawing.Image)(resources.GetObject("button_Delete.Image")));
            this.button_Delete.ImageActive = null;
            this.button_Delete.Location = new System.Drawing.Point(550, 221);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(71, 56);
            this.button_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Delete.TabIndex = 3;
            this.button_Delete.TabStop = false;
            this.button_Delete.Zoom = 10;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.Gold;
            this.button_Update.Image = ((System.Drawing.Image)(resources.GetObject("button_Update.Image")));
            this.button_Update.ImageActive = null;
            this.button_Update.Location = new System.Drawing.Point(436, 221);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(71, 56);
            this.button_Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Update.TabIndex = 2;
            this.button_Update.TabStop = false;
            this.button_Update.Zoom = 10;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.SeaGreen;
            this.button_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Add.BackgroundImage")));
            this.button_Add.Image = ((System.Drawing.Image)(resources.GetObject("button_Add.Image")));
            this.button_Add.ImageActive = null;
            this.button_Add.Location = new System.Drawing.Point(326, 221);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(71, 56);
            this.button_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Add.TabIndex = 1;
            this.button_Add.TabStop = false;
            this.button_Add.Zoom = 10;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
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
            this.dataGridView_ListDog.Location = new System.Drawing.Point(39, -1);
            this.dataGridView_ListDog.Name = "dataGridView_ListDog";
            this.dataGridView_ListDog.Size = new System.Drawing.Size(834, 216);
            this.dataGridView_ListDog.TabIndex = 0;
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
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(39, 221);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.button_Refresh.TabIndex = 18;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // DogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 304);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DogForm";
            this.Text = "DogForm";
            this.Load += new System.EventHandler(this.DogForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_Adoption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListDog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton button_Delete;
        private Bunifu.Framework.UI.BunifuImageButton button_Update;
        private Bunifu.Framework.UI.BunifuImageButton button_Add;
        private System.Windows.Forms.DataGridView dataGridView_ListDog;
        public System.Windows.Forms.Label label_Add;
        public System.Windows.Forms.Label label_Update;
        public System.Windows.Forms.Label label_Delete;
        public System.Windows.Forms.Label label_Adoption;
        private Bunifu.Framework.UI.BunifuImageButton button_Adoption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Date_of_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Breed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dog_Charater;
        private System.Windows.Forms.Button button_Refresh;
    }
}