namespace DogForLife
{
    partial class AUMeetingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AUMeetingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.comboBox_OwnerID = new System.Windows.Forms.ComboBox();
            this.label_OwnerID = new System.Windows.Forms.Label();
            this.comboBox_DogChip = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.bunifuFlatButton_Cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton_Ok = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTextbox_ID = new Bunifu.Framework.UI.BunifuTextbox();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Dog = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.dateTimePicker_Time = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Worker = new System.Windows.Forms.ComboBox();
            this.label_Worker = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.comboBox_Worker);
            this.panel1.Controls.Add(this.label_Worker);
            this.panel1.Controls.Add(this.dateTimePicker_Time);
            this.panel1.Controls.Add(this.label_Title);
            this.panel1.Controls.Add(this.label_Time);
            this.panel1.Controls.Add(this.comboBox_OwnerID);
            this.panel1.Controls.Add(this.label_OwnerID);
            this.panel1.Controls.Add(this.comboBox_DogChip);
            this.panel1.Controls.Add(this.dateTimePicker_Date);
            this.panel1.Controls.Add(this.bunifuFlatButton_Cancel);
            this.panel1.Controls.Add(this.bunifuFlatButton_Ok);
            this.panel1.Controls.Add(this.bunifuTextbox_ID);
            this.panel1.Controls.Add(this.label_Date);
            this.panel1.Controls.Add(this.label_Dog);
            this.panel1.Controls.Add(this.label_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 461);
            this.panel1.TabIndex = 2;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.Black;
            this.label_Title.Location = new System.Drawing.Point(88, 23);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(198, 32);
            this.label_Title.TabIndex = 33;
            this.label_Title.Text = "Add Meeting";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(34, 317);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(53, 24);
            this.label_Time.TabIndex = 31;
            this.label_Time.Text = "Time";
            // 
            // comboBox_OwnerID
            // 
            this.comboBox_OwnerID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_OwnerID.ForeColor = System.Drawing.Color.Black;
            this.comboBox_OwnerID.FormattingEnabled = true;
            this.comboBox_OwnerID.Location = new System.Drawing.Point(169, 222);
            this.comboBox_OwnerID.Name = "comboBox_OwnerID";
            this.comboBox_OwnerID.Size = new System.Drawing.Size(155, 21);
            this.comboBox_OwnerID.TabIndex = 29;
            // 
            // label_OwnerID
            // 
            this.label_OwnerID.AutoSize = true;
            this.label_OwnerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_OwnerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OwnerID.Location = new System.Drawing.Point(31, 222);
            this.label_OwnerID.Name = "label_OwnerID";
            this.label_OwnerID.Size = new System.Drawing.Size(67, 24);
            this.label_OwnerID.TabIndex = 28;
            this.label_OwnerID.Text = "Owner";
            // 
            // comboBox_DogChip
            // 
            this.comboBox_DogChip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_DogChip.ForeColor = System.Drawing.Color.Black;
            this.comboBox_DogChip.FormattingEnabled = true;
            this.comboBox_DogChip.Location = new System.Drawing.Point(169, 176);
            this.comboBox_DogChip.Name = "comboBox_DogChip";
            this.comboBox_DogChip.Size = new System.Drawing.Size(155, 21);
            this.comboBox_DogChip.TabIndex = 27;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Date.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker_Date.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker_Date.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateTimePicker_Date.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker_Date.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dateTimePicker_Date.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(169, 266);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(155, 29);
            this.dateTimePicker_Date.TabIndex = 26;
            // 
            // bunifuFlatButton_Cancel
            // 
            this.bunifuFlatButton_Cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_Cancel.BackColor = System.Drawing.Color.Red;
            this.bunifuFlatButton_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton_Cancel.BorderRadius = 0;
            this.bunifuFlatButton_Cancel.ButtonText = "Cancel";
            this.bunifuFlatButton_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton_Cancel.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton_Cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_Cancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton_Cancel.Iconimage")));
            this.bunifuFlatButton_Cancel.Iconimage_right = null;
            this.bunifuFlatButton_Cancel.Iconimage_right_Selected = null;
            this.bunifuFlatButton_Cancel.Iconimage_Selected = null;
            this.bunifuFlatButton_Cancel.IconMarginLeft = 0;
            this.bunifuFlatButton_Cancel.IconMarginRight = 0;
            this.bunifuFlatButton_Cancel.IconRightVisible = true;
            this.bunifuFlatButton_Cancel.IconRightZoom = 0D;
            this.bunifuFlatButton_Cancel.IconVisible = true;
            this.bunifuFlatButton_Cancel.IconZoom = 90D;
            this.bunifuFlatButton_Cancel.IsTab = false;
            this.bunifuFlatButton_Cancel.Location = new System.Drawing.Point(22, 385);
            this.bunifuFlatButton_Cancel.Name = "bunifuFlatButton_Cancel";
            this.bunifuFlatButton_Cancel.Normalcolor = System.Drawing.Color.Red;
            this.bunifuFlatButton_Cancel.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButton_Cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton_Cancel.selected = false;
            this.bunifuFlatButton_Cancel.Size = new System.Drawing.Size(122, 48);
            this.bunifuFlatButton_Cancel.TabIndex = 25;
            this.bunifuFlatButton_Cancel.Text = "Cancel";
            this.bunifuFlatButton_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton_Cancel.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton_Cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton_Cancel.Click += new System.EventHandler(this.bunifuFlatButton_Cancel_Click);
            // 
            // bunifuFlatButton_Ok
            // 
            this.bunifuFlatButton_Ok.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton_Ok.BorderRadius = 0;
            this.bunifuFlatButton_Ok.ButtonText = "OK";
            this.bunifuFlatButton_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton_Ok.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton_Ok.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_Ok.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton_Ok.Iconimage")));
            this.bunifuFlatButton_Ok.Iconimage_right = null;
            this.bunifuFlatButton_Ok.Iconimage_right_Selected = null;
            this.bunifuFlatButton_Ok.Iconimage_Selected = null;
            this.bunifuFlatButton_Ok.IconMarginLeft = 0;
            this.bunifuFlatButton_Ok.IconMarginRight = 0;
            this.bunifuFlatButton_Ok.IconRightVisible = true;
            this.bunifuFlatButton_Ok.IconRightZoom = 0D;
            this.bunifuFlatButton_Ok.IconVisible = true;
            this.bunifuFlatButton_Ok.IconZoom = 90D;
            this.bunifuFlatButton_Ok.IsTab = false;
            this.bunifuFlatButton_Ok.Location = new System.Drawing.Point(186, 385);
            this.bunifuFlatButton_Ok.Name = "bunifuFlatButton_Ok";
            this.bunifuFlatButton_Ok.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_Ok.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton_Ok.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton_Ok.selected = false;
            this.bunifuFlatButton_Ok.Size = new System.Drawing.Size(122, 48);
            this.bunifuFlatButton_Ok.TabIndex = 24;
            this.bunifuFlatButton_Ok.Text = "OK";
            this.bunifuFlatButton_Ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton_Ok.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton_Ok.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton_Ok.Click += new System.EventHandler(this.bunifuFlatButton_Ok_Click);
            // 
            // bunifuTextbox_ID
            // 
            this.bunifuTextbox_ID.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox_ID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox_ID.BackgroundImage")));
            this.bunifuTextbox_ID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox_ID.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox_ID.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox_ID.Icon")));
            this.bunifuTextbox_ID.Location = new System.Drawing.Point(169, 96);
            this.bunifuTextbox_ID.Name = "bunifuTextbox_ID";
            this.bunifuTextbox_ID.Size = new System.Drawing.Size(155, 25);
            this.bunifuTextbox_ID.TabIndex = 9;
            this.bunifuTextbox_ID.text = "";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(31, 266);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(48, 24);
            this.label_Date.TabIndex = 2;
            this.label_Date.Text = "Date";
            // 
            // label_Dog
            // 
            this.label_Dog.AutoSize = true;
            this.label_Dog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_Dog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dog.Location = new System.Drawing.Point(31, 176);
            this.label_Dog.Name = "label_Dog";
            this.label_Dog.Size = new System.Drawing.Size(45, 24);
            this.label_Dog.TabIndex = 1;
            this.label_Dog.Text = "Dog";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(34, 96);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(27, 24);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID";
            // 
            // dateTimePicker_Time
            // 
            this.dateTimePicker_Time.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Time.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker_Time.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker_Time.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateTimePicker_Time.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker_Time.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.dateTimePicker_Time.CustomFormat = "hh:mm";
            this.dateTimePicker_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_Time.Location = new System.Drawing.Point(169, 317);
            this.dateTimePicker_Time.Name = "dateTimePicker_Time";
            this.dateTimePicker_Time.Size = new System.Drawing.Size(155, 29);
            this.dateTimePicker_Time.TabIndex = 34;
            this.dateTimePicker_Time.Value = new System.DateTime(2021, 2, 28, 20, 48, 0, 0);
            // 
            // comboBox_Worker
            // 
            this.comboBox_Worker.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_Worker.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Worker.FormattingEnabled = true;
            this.comboBox_Worker.Location = new System.Drawing.Point(169, 136);
            this.comboBox_Worker.Name = "comboBox_Worker";
            this.comboBox_Worker.Size = new System.Drawing.Size(155, 21);
            this.comboBox_Worker.TabIndex = 36;
            // 
            // label_Worker
            // 
            this.label_Worker.AutoSize = true;
            this.label_Worker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_Worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Worker.Location = new System.Drawing.Point(31, 136);
            this.label_Worker.Name = "label_Worker";
            this.label_Worker.Size = new System.Drawing.Size(71, 24);
            this.label_Worker.TabIndex = 35;
            this.label_Worker.Text = "Worker";
            // 
            // AUMeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AUMeetingForm";
            this.Text = "AUMeetingForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.ComboBox comboBox_OwnerID;
        private System.Windows.Forms.Label label_OwnerID;
        private System.Windows.Forms.ComboBox comboBox_DogChip;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton_Cancel;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton_Ok;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox_ID;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Dog;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Time;
        private System.Windows.Forms.ComboBox comboBox_Worker;
        private System.Windows.Forms.Label label_Worker;
    }
}