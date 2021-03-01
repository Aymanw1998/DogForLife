namespace DogForLife
{
    partial class MeetingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_Add = new System.Windows.Forms.Label();
            this.label_Update = new System.Windows.Forms.Label();
            this.label_Delete = new System.Windows.Forms.Label();
            this.bunifuImageButton_Delete = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton_Update = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton_Add = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridView_ListMeeting = new System.Windows.Forms.DataGridView();
            this.Meeting_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meeting_ID_Dog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meeting_Dog_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meeting_ID_Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meeting_Worker_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meeting_ID_Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meeting_Owner_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meeting_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meeting_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meeting_Adopter = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton_Update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListMeeting)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button_Refresh);
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.label_Add);
            this.panel1.Controls.Add(this.label_Update);
            this.panel1.Controls.Add(this.label_Delete);
            this.panel1.Controls.Add(this.bunifuImageButton_Delete);
            this.panel1.Controls.Add(this.bunifuImageButton_Update);
            this.panel1.Controls.Add(this.bunifuImageButton_Add);
            this.panel1.Controls.Add(this.dataGridView_ListMeeting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 304);
            this.panel1.TabIndex = 3;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(831, 223);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 13;
            this.button_Save.Text = "SaveStatus";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label_Add
            // 
            this.label_Add.AutoSize = true;
            this.label_Add.BackColor = System.Drawing.Color.SeaGreen;
            this.label_Add.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Add.Location = new System.Drawing.Point(353, 279);
            this.label_Add.Name = "label_Add";
            this.label_Add.Size = new System.Drawing.Size(39, 21);
            this.label_Add.TabIndex = 12;
            this.label_Add.Text = "Add";
            // 
            // label_Update
            // 
            this.label_Update.AutoSize = true;
            this.label_Update.BackColor = System.Drawing.Color.Gold;
            this.label_Update.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Update.Location = new System.Drawing.Point(453, 279);
            this.label_Update.Name = "label_Update";
            this.label_Update.Size = new System.Drawing.Size(63, 21);
            this.label_Update.TabIndex = 11;
            this.label_Update.Text = "Update";
            // 
            // label_Delete
            // 
            this.label_Delete.AutoSize = true;
            this.label_Delete.BackColor = System.Drawing.Color.Red;
            this.label_Delete.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Delete.Location = new System.Drawing.Point(572, 279);
            this.label_Delete.Name = "label_Delete";
            this.label_Delete.Size = new System.Drawing.Size(57, 21);
            this.label_Delete.TabIndex = 10;
            this.label_Delete.Text = "Delete";
            // 
            // bunifuImageButton_Delete
            // 
            this.bunifuImageButton_Delete.BackColor = System.Drawing.Color.Red;
            this.bunifuImageButton_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Delete.BackgroundImage")));
            this.bunifuImageButton_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuImageButton_Delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuImageButton_Delete.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Delete.Image")));
            this.bunifuImageButton_Delete.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Delete.ImageActive")));
            this.bunifuImageButton_Delete.Location = new System.Drawing.Point(562, 223);
            this.bunifuImageButton_Delete.Name = "bunifuImageButton_Delete";
            this.bunifuImageButton_Delete.Size = new System.Drawing.Size(71, 56);
            this.bunifuImageButton_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton_Delete.TabIndex = 7;
            this.bunifuImageButton_Delete.TabStop = false;
            this.bunifuImageButton_Delete.Zoom = 10;
            this.bunifuImageButton_Delete.Click += new System.EventHandler(this.bunifuImageButton_Delete_Click);
            // 
            // bunifuImageButton_Update
            // 
            this.bunifuImageButton_Update.BackColor = System.Drawing.Color.Gold;
            this.bunifuImageButton_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Update.BackgroundImage")));
            this.bunifuImageButton_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuImageButton_Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuImageButton_Update.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Update.Image")));
            this.bunifuImageButton_Update.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Update.ImageActive")));
            this.bunifuImageButton_Update.Location = new System.Drawing.Point(448, 223);
            this.bunifuImageButton_Update.Name = "bunifuImageButton_Update";
            this.bunifuImageButton_Update.Size = new System.Drawing.Size(71, 56);
            this.bunifuImageButton_Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton_Update.TabIndex = 6;
            this.bunifuImageButton_Update.TabStop = false;
            this.bunifuImageButton_Update.Zoom = 10;
            this.bunifuImageButton_Update.Click += new System.EventHandler(this.bunifuImageButton_Update_Click);
            // 
            // bunifuImageButton_Add
            // 
            this.bunifuImageButton_Add.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Add.BackgroundImage")));
            this.bunifuImageButton_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuImageButton_Add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuImageButton_Add.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Add.Image")));
            this.bunifuImageButton_Add.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_Add.ImageActive")));
            this.bunifuImageButton_Add.Location = new System.Drawing.Point(338, 223);
            this.bunifuImageButton_Add.Name = "bunifuImageButton_Add";
            this.bunifuImageButton_Add.Size = new System.Drawing.Size(71, 56);
            this.bunifuImageButton_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton_Add.TabIndex = 5;
            this.bunifuImageButton_Add.TabStop = false;
            this.bunifuImageButton_Add.Zoom = 10;
            this.bunifuImageButton_Add.Click += new System.EventHandler(this.bunifuImageButton_Add_Click);
            // 
            // dataGridView_ListMeeting
            // 
            this.dataGridView_ListMeeting.AllowUserToAddRows = false;
            this.dataGridView_ListMeeting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView_ListMeeting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListMeeting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Meeting_ID,
            this.Meeting_ID_Dog,
            this.Meeting_Dog_Name,
            this.Meeting_ID_Worker,
            this.Meeting_Worker_Name,
            this.Meeting_ID_Owner,
            this.Meeting_Owner_Name,
            this.Meeting_Date,
            this.Meeting_Time,
            this.Meeting_Adopter});
            this.dataGridView_ListMeeting.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ListMeeting.Name = "dataGridView_ListMeeting";
            this.dataGridView_ListMeeting.Size = new System.Drawing.Size(941, 207);
            this.dataGridView_ListMeeting.TabIndex = 4;
            // 
            // Meeting_ID
            // 
            this.Meeting_ID.HeaderText = "ID";
            this.Meeting_ID.Name = "Meeting_ID";
            this.Meeting_ID.ReadOnly = true;
            this.Meeting_ID.Width = 176;
            // 
            // Meeting_ID_Dog
            // 
            this.Meeting_ID_Dog.HeaderText = "ID_Dog";
            this.Meeting_ID_Dog.Name = "Meeting_ID_Dog";
            this.Meeting_ID_Dog.ReadOnly = true;
            this.Meeting_ID_Dog.Visible = false;
            this.Meeting_ID_Dog.Width = 200;
            // 
            // Meeting_Dog_Name
            // 
            this.Meeting_Dog_Name.HeaderText = "Dog";
            this.Meeting_Dog_Name.Name = "Meeting_Dog_Name";
            this.Meeting_Dog_Name.ReadOnly = true;
            this.Meeting_Dog_Name.Width = 176;
            // 
            // Meeting_ID_Worker
            // 
            this.Meeting_ID_Worker.HeaderText = "ID_Worker";
            this.Meeting_ID_Worker.Name = "Meeting_ID_Worker";
            this.Meeting_ID_Worker.Visible = false;
            // 
            // Meeting_Worker_Name
            // 
            this.Meeting_Worker_Name.HeaderText = "Worker";
            this.Meeting_Worker_Name.Name = "Meeting_Worker_Name";
            this.Meeting_Worker_Name.Width = 180;
            // 
            // Meeting_ID_Owner
            // 
            this.Meeting_ID_Owner.HeaderText = "ID_Owner";
            this.Meeting_ID_Owner.Name = "Meeting_ID_Owner";
            this.Meeting_ID_Owner.ReadOnly = true;
            this.Meeting_ID_Owner.Visible = false;
            // 
            // Meeting_Owner_Name
            // 
            this.Meeting_Owner_Name.HeaderText = "Owner";
            this.Meeting_Owner_Name.Name = "Meeting_Owner_Name";
            this.Meeting_Owner_Name.ReadOnly = true;
            this.Meeting_Owner_Name.Width = 180;
            // 
            // Meeting_Date
            // 
            this.Meeting_Date.HeaderText = "Date";
            this.Meeting_Date.Name = "Meeting_Date";
            this.Meeting_Date.ReadOnly = true;
            this.Meeting_Date.Width = 180;
            // 
            // Meeting_Time
            // 
            this.Meeting_Time.HeaderText = "Time";
            this.Meeting_Time.Name = "Meeting_Time";
            this.Meeting_Time.ReadOnly = true;
            this.Meeting_Time.Width = 180;
            // 
            // Meeting_Adopter
            // 
            this.Meeting_Adopter.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Meeting_Adopter.HeaderText = "Adopter";
            this.Meeting_Adopter.Name = "Meeting_Adopter";
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(3, 213);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.button_Refresh.TabIndex = 14;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // MeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 304);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeetingForm";
            this.Text = "MeetingForm";
            this.Load += new System.EventHandler(this.MeetingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton_Update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListMeeting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton_Delete;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton_Update;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton_Add;
        private System.Windows.Forms.DataGridView dataGridView_ListMeeting;
        public System.Windows.Forms.Label label_Add;
        public System.Windows.Forms.Label label_Update;
        public System.Windows.Forms.Label label_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meeting_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meeting_ID_Dog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meeting_Dog_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meeting_ID_Worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meeting_Worker_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meeting_ID_Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meeting_Owner_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meeting_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meeting_Time;
        private System.Windows.Forms.DataGridViewComboBoxColumn Meeting_Adopter;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Refresh;
    }
}