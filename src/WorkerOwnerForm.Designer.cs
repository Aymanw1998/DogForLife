namespace DogForLife
{
    partial class WorkerOwnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerOwnerForm));
            this.panelMain = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Panel();
            this.button_Logout = new System.Windows.Forms.Button();
            this.tabControl_Forms = new System.Windows.Forms.TabControl();
            this.button_Profile = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_Meeting = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_Dog = new Bunifu.Framework.UI.BunifuImageButton();
            this.label_Title = new System.Windows.Forms.Label();
            this.bunifuImageButton_AddWorker = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Meeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Dog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton_AddWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.bunifuImageButton_AddWorker);
            this.panelMain.Controls.Add(this.button_Exit);
            this.panelMain.Controls.Add(this.button_Logout);
            this.panelMain.Controls.Add(this.tabControl_Forms);
            this.panelMain.Controls.Add(this.button_Profile);
            this.panelMain.Controls.Add(this.button_Meeting);
            this.panelMain.Controls.Add(this.button_Dog);
            this.panelMain.Controls.Add(this.label_Title);
            this.panelMain.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelMain.Location = new System.Drawing.Point(-45, -57);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1025, 684);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // button_Exit
            // 
            this.button_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Exit.BackgroundImage")));
            this.button_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Exit.Location = new System.Drawing.Point(45, 64);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_Exit.Size = new System.Drawing.Size(37, 32);
            this.button_Exit.TabIndex = 10;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.AutoSize = true;
            this.button_Logout.BackColor = System.Drawing.Color.Salmon;
            this.button_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Logout.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.button_Logout.FlatAppearance.BorderSize = 10;
            this.button_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.button_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Logout.Font = new System.Drawing.Font("French Script MT", 15F);
            this.button_Logout.Location = new System.Drawing.Point(866, 154);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Padding = new System.Windows.Forms.Padding(6);
            this.button_Logout.Size = new System.Drawing.Size(93, 45);
            this.button_Logout.TabIndex = 9;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // tabControl_Forms
            // 
            this.tabControl_Forms.Location = new System.Drawing.Point(45, 205);
            this.tabControl_Forms.Name = "tabControl_Forms";
            this.tabControl_Forms.SelectedIndex = 0;
            this.tabControl_Forms.Size = new System.Drawing.Size(938, 422);
            this.tabControl_Forms.TabIndex = 8;
            this.tabControl_Forms.Visible = false;
            // 
            // button_Profile
            // 
            this.button_Profile.BackColor = System.Drawing.Color.SeaGreen;
            this.button_Profile.Image = ((System.Drawing.Image)(resources.GetObject("button_Profile.Image")));
            this.button_Profile.ImageActive = null;
            this.button_Profile.Location = new System.Drawing.Point(585, 128);
            this.button_Profile.Name = "button_Profile";
            this.button_Profile.Size = new System.Drawing.Size(71, 71);
            this.button_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Profile.TabIndex = 7;
            this.button_Profile.TabStop = false;
            this.button_Profile.Zoom = 10;
            this.button_Profile.Click += new System.EventHandler(this.button_Profile_Click);
            // 
            // button_Meeting
            // 
            this.button_Meeting.BackColor = System.Drawing.Color.SeaGreen;
            this.button_Meeting.Image = ((System.Drawing.Image)(resources.GetObject("button_Meeting.Image")));
            this.button_Meeting.ImageActive = null;
            this.button_Meeting.Location = new System.Drawing.Point(486, 128);
            this.button_Meeting.Name = "button_Meeting";
            this.button_Meeting.Size = new System.Drawing.Size(71, 71);
            this.button_Meeting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Meeting.TabIndex = 6;
            this.button_Meeting.TabStop = false;
            this.button_Meeting.Zoom = 10;
            this.button_Meeting.Click += new System.EventHandler(this.button_Meeting_Click);
            // 
            // button_Dog
            // 
            this.button_Dog.BackColor = System.Drawing.Color.SeaGreen;
            this.button_Dog.Image = ((System.Drawing.Image)(resources.GetObject("button_Dog.Image")));
            this.button_Dog.ImageActive = null;
            this.button_Dog.Location = new System.Drawing.Point(378, 128);
            this.button_Dog.Name = "button_Dog";
            this.button_Dog.Size = new System.Drawing.Size(71, 71);
            this.button_Dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Dog.TabIndex = 5;
            this.button_Dog.TabStop = false;
            this.button_Dog.Zoom = 10;
            this.button_Dog.Click += new System.EventHandler(this.button_Dog_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.SystemColors.Control;
            this.label_Title.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.Black;
            this.label_Title.Location = new System.Drawing.Point(455, 80);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(119, 32);
            this.label_Title.TabIndex = 4;
            this.label_Title.Text = "Worker";
            // 
            // bunifuImageButton_AddWorker
            // 
            this.bunifuImageButton_AddWorker.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton_AddWorker.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton_AddWorker.Image")));
            this.bunifuImageButton_AddWorker.ImageActive = null;
            this.bunifuImageButton_AddWorker.Location = new System.Drawing.Point(272, 128);
            this.bunifuImageButton_AddWorker.Name = "bunifuImageButton_AddWorker";
            this.bunifuImageButton_AddWorker.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton_AddWorker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton_AddWorker.TabIndex = 11;
            this.bunifuImageButton_AddWorker.TabStop = false;
            this.bunifuImageButton_AddWorker.Zoom = 10;
            this.bunifuImageButton_AddWorker.Click += new System.EventHandler(this.bunifuImageButton_AddWorker_Click);
            // 
            // WorkerOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 570);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerOwnerForm";
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Meeting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Dog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton_AddWorker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabControl_Forms;
        private Bunifu.Framework.UI.BunifuImageButton button_Profile;
        private Bunifu.Framework.UI.BunifuImageButton button_Meeting;
        private Bunifu.Framework.UI.BunifuImageButton button_Dog;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Panel button_Exit;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton_AddWorker;
    }
}